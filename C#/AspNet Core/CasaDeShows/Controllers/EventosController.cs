using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CasaDeShows.Data;
using CasaDeShows.Models;
using CasaDeShows.DTO;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CasaDeShows.Controllers
{
    public class EventosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public EventosController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public void EnviaForm([FromBody] EventoDTO eventoTemp)
        {
            if (ModelState.IsValid)
            {
                var casaDeShowAchada = _context.casasDeShow.Where(cs => cs.Id == Convert.ToInt32(eventoTemp.CasaDeShowsId)).FirstOrDefault();
                Eventos evento = new Eventos()
                {
                    CasaDeShows = casaDeShowAchada,
                    Nome = eventoTemp.Nome,
                    Data = eventoTemp.Data,
                    Preco = Convert.ToDouble(eventoTemp.Preco),
                    Genero = Convert.ToInt32(eventoTemp.GeneroId),
                    Ingressos = Convert.ToInt32(eventoTemp.Ingressos)
                };
                _context.Eventos.Add(evento);
                _context.SaveChanges();
            }
        }

        public IActionResult SalvaImagemEvento() {
            return View();
        }


        [HttpPost]
        public IActionResult SalvarImagem(ImagemEventoDTO imagem)
        {
            string email = User.Identity.Name.ToString().Replace("@", "_");
            string uniqueFileName = null;

            // If the Photo property on the incoming model object is not null, then the user
            // has selected an image to upload.
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "usuarios/" + email + "/imagePerfil"); // acha a pasta root da aplica��o

                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                Random random = new Random();

                uniqueFileName = Guid.NewGuid().ToString() + "_" + imagem.ImagemEvento.FileName + random.Next(1000).ToString(); // cria um nome unico para a imagem

                string filePath = Path.Combine(uploadsFolder, uniqueFileName); // cria o caminho completop

                imagem.ImagemEvento.CopyTo(new FileStream(filePath, FileMode.Create)); // coloca a imagem l�

            return LocalRedirect("~/Evento/Index/");//retornar para o controler e nao para o arquivo cshtml!!!
        }


        // GET: Eventos
        public async Task<IActionResult> Index()
        {
            ViewBag.casaDeShow = _context.casasDeShow.ToList();
            return View(await _context.Eventos.ToListAsync());
        }

        // GET: Eventos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventos = await _context.Eventos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventos == null)
            {
                return NotFound();
            }

            return View(eventos);
        }

        // GET: Eventos/Create
        public IActionResult Criando()
        {
            ViewBag.batata = _context.casasDeShow.ToList();
            return View();
        }

        // POST: Eventos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        // GET: Eventos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventos = await _context.Eventos.FindAsync(id);
            if (eventos == null)
            {
                return NotFound();
            }
            ViewBag.casaDeShow = _context.casasDeShow.ToList();
            return View(eventos);
        }

        // POST: Eventos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Preco,data,Ingressos,CasaDeShows")] Eventos eventos)
        {
            if (id != eventos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ViewBag.casaDeShow = _context.casasDeShow.ToList();
                    _context.Update(eventos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventosExists(eventos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(eventos);
        }

        // GET: Eventos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventos = await _context.Eventos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventos == null)
            {
                return NotFound();
            }

            return View(eventos);
        }

        // POST: Eventos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventos = await _context.Eventos.FindAsync(id);
            _context.Eventos.Remove(eventos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventosExists(int id)
        {
            return _context.Eventos.Any(e => e.Id == id);
        }
    }
}
