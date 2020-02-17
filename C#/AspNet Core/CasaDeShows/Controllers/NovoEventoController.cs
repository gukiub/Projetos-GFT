using CasaDeShows.Data;
using CasaDeShows.DTO;
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
        public void EnviaForm([FromBody] EventoDTO evento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(evento);
                _context.SaveChangesAsync();
            }
        }
    }
}
