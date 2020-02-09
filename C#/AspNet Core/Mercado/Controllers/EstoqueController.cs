using Mercado.Data;
using Mercado.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mercado.Controllers
{
    public class EstoqueController : Controller
    {

        private readonly ApplicationDbContext database;

        public EstoqueController(ApplicationDbContext database){
            this.database = database;
        }
        

        [HttpPost]
        public IActionResult Salvar(Estoque estoqueTemp){
            database.Estoques.Add(estoqueTemp);
            database.SaveChanges();
            return RedirectToAction("Estoque", "Gestao");
        }   
    }
}