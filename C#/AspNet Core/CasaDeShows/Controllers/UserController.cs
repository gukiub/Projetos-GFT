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

        public IActionResult Index(){
            var eventos = _context.Eventos.ToList();
            var casa = _context.casasDeShow.ToList();
            return View(eventos);
        }
    }
}