using CasaDeShows.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CasaDeShows.Models;
using CasaDeShows.DTO;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CasaDeShows.Controllers
{
    public class UserController : Controller
    {
        readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(){
            var eventos = _context.Eventos.Include(cs => cs.CasaDeShows).ToList();
            return View(eventos);
        }

        [HttpGet]
        public IActionResult Comprando(int id) {
            var evento = _context.Eventos.Include(cs => cs.CasaDeShows).FirstOrDefault(eve => eve.Id == id);
            EventoDTO eveDTO = new EventoDTO();
            eveDTO.Id = evento.Id;
            eveDTO.Nome = evento.Nome;
            eveDTO.Preco = evento.Preco.ToString();
            eveDTO.Ingressos = evento.Ingressos.ToString();
            eveDTO.GeneroId = evento.Genero.ToString();
            eveDTO.Data = evento.Data;
            eveDTO.CasaDeShowsId = evento.CasaDeShows.Id.ToString();
            eveDTO.CaminhoImagem = evento.Imagem;
            //evento.Ingressos -= 1;
            //_context.Attach(evento).State = EntityState.Modified;
            //_context.SaveChanges();
            return View("Compra", eveDTO);
        }

        [HttpPost]
        public IActionResult ConfirmarCompra(int quantidade, [Bind("Id")] EventoDTO eventos) {
            var compra = _context.Eventos.Where(eve => eve.Id == eventos.Id).FirstOrDefault();
            compra.Ingressos -= quantidade;
            _context.Attach(compra).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}