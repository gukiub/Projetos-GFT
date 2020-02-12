using System.Linq;
using CasaDeShows.Data;
using CasaDeShows.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasaDeShows.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext database;

        public AdminController(ApplicationDbContext database){
            this.database = database;
        }
        
        public IActionResult Index(){
            var casas = database.casasDeShow.First();
            return View();
        }

        public IActionResult NovaCasa(){
            return View();
        }
    }
}