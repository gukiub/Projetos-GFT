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
using Microsoft.AspNetCore.Authorization;

namespace CasaDeShows.Controllers
{
    [Authorize(Policy = "Administrador")]
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
        public string EnviaForm([FromBody] EventoDTO eventoTemp)
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
                    Ingressos = Convert.ToInt32(eventoTemp.Ingressos),
                    Imagem = "/Login_v16/images/bg-01.jpg"
                };
                var existe = _context.casasDeShow.Where(ex => ex.Nome.Equals(eventoTemp.Nome)).Any();
                if (existe == true)
                {
                    return "erro";
                }
                else
                {
                    _context.Eventos.Add(evento);
                    _context.SaveChanges();
                    string Id = _context.Eventos.Where(eve => eve.Nome.Equals(eventoTemp.Nome)).FirstOrDefault().Id.ToString();
                    return Id;
                }
            }
            return "erro";
        }

        public IActionResult SalvaImagemEvento(string Id)
        {
            ViewData["eventoId"] = Id;
            return View();
        }


        [HttpPost]
        public IActionResult SalvarImagem(ImagemEventoDTO imagem)
        {
            string email = User.Identity.Name.ToString().Replace("@", "_");
            string uniqueFileName = null;

            // If the Photo property on the incoming model object is not null, then the user
            // has selected an image to upload.
            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "usuarios/" + email + "/imagePerfil"); // acha a pasta root 

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            uniqueFileName = Guid.NewGuid().ToString() + "_" + imagem.ImagemEvento.FileName; // cria um nome unico para a imagem

            string filePath = Path.Combine(uploadsFolder, uniqueFileName); // cria o caminho completop

            imagem.ImagemEvento.CopyTo(new FileStream(filePath, FileMode.Create)); // coloca a imagem 
            var pesquisa = _context.Eventos.Where(eve => eve.Id == imagem.EventoId).FirstOrDefault();
            string caminhoDaView = string.Format("/usuarios/{0}/imagePerfil/{1}", email, uniqueFileName);
            pesquisa.Imagem = caminhoDaView;
            _context.Attach(pesquisa).State = EntityState.Modified;
            _context.SaveChanges();


            return RedirectToAction("Index", "Eventos");//retornar para o controler e nao para o arquivo cshtm
        }


        // GET: Eventos
        public async Task<IActionResult> Index()
        {
            ViewBag.casaDeShow = _context.casasDeShow.ToList();

            if (_context.casasDeShow.Count() != 0)
            {
                return View(await _context.Eventos.ToListAsync());
            }
            else
            {
                return View("ErroEvento");
            }
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
            ViewBag.batata = _context.casasDeShow.ToList();
            EventoDTO eveDTO = new EventoDTO()
            {
                Id = eventos.Id,
                Nome = eventos.Nome,
                Preco = eventos.Preco.ToString(),
                CasaDeShowsId = eventos.CasaDeShows.Id.ToString(),
                GeneroId = eventos.Genero.ToString(),
                Data = eventos.Data,
                Ingressos = eventos.Ingressos.ToString()
            };

            return View(eveDTO);
        }

        // POST: Eventos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,CasaDeShowsId,Preco,GeneroId,Data,Ingressos")] EventoDTO eventos)
        {
            if (ModelState.IsValid)
            {
                var eventoEditar = _context.Eventos.Where(eve => eve.Id == id).FirstOrDefault();
                eventoEditar.Nome = eventos.Nome;
                eventoEditar.Preco = Convert.ToDouble(eventos.Preco);
                eventoEditar.Ingressos = Convert.ToInt32(eventos.Ingressos);
                eventoEditar.Data = eventos.Data;
                eventoEditar.Genero = Convert.ToInt32(eventos.GeneroId);

                var casaDeshow = _context.casasDeShow.Where(cs => cs.Id == Convert.ToInt32(eventos.CasaDeShowsId)).FirstOrDefault();
                eventoEditar.CasaDeShows = casaDeshow;


                try
                {
                    ViewBag.batata = _context.casasDeShow.ToList();

                    _context.Attach(eventoEditar).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.batata = _context.casasDeShow.ToList();
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

        [HttpGet]
        public IActionResult ErroEvento()
        {
            return View();
        }
    }
}
