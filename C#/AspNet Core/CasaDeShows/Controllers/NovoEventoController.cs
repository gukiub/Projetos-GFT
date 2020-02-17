using CasaDeShows.Data;
using CasaDeShows.DTO;
using CasaDeShows.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDeShows.Controllers
{
    public class NovoEventoController : Controller
    {

        private readonly ApplicationDbContext _context;

        public NovoEventoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Criando() 
        {
            ViewBag.batata = _context.casasDeShow.ToList();
            return View();
        }


        [HttpPost]
        public void EnviaForm([FromBody] EventoDTO eventoTemp)
        {
            if (ModelState.IsValid)
            {
                Eventos evento = new Eventos();
                evento.Nome = eventoTemp.Nome;
                evento.Preco = System.Convert.ToDouble(eventoTemp.Preco);
                evento.Ingressos = System.Convert.ToInt32(eventoTemp.Ingressos);
                evento.Data = System.Convert.ToDateTime(eventoTemp.Data);
                evento.CasaDeShows = _context.casasDeShow.First(cs => cs.Id == Convert.ToInt32(eventoTemp.CasaDeShowsId));
                _context.Add(evento);
                _context.SaveChanges();
            }
        }
    }
}
