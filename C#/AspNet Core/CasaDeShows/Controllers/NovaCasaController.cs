using System.Linq;
using CasaDeShows.Data;
using CasaDeShows.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasaDeShows.Controllers
{
    public class NovaCasaController : Controller
    {

        private readonly ApplicationDbContext database;

        public NovaCasaController(ApplicationDbContext database){
            this.database = database;
        }
        
        [HttpPost]
        public IActionResult Salvar(CasasDeShow casasDeShow){
            if(ModelState.IsValid){
                CasasDeShow casas = new CasasDeShow();
                casas.Nome = casasDeShow.Nome;
                casas.Capacidade = casasDeShow.Capacidade;
                casas.Bandas = casasDeShow.Bandas;
                casas.IngressosDisp = casasDeShow.IngressosDisp;
                casas.Local = casasDeShow.Local;
                database.casasDeShow.Add(casasDeShow);
                database.SaveChanges();
                return RedirectToAction("Index", "Home");
            } else{
                return View("../Admin/Index");   
            }
        }
    }
}