using Microsoft.AspNetCore.Mvc;
using System;
using Mercado.DTO;
using Mercado.Models;
using Mercado.Data;

namespace Mercado.Controllers
{
    public class CategoriasController : Controller
    {

        private readonly ApplicationDbContext database;

        public CategoriasController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(CategoriaDTO categoriaTemporaria){
            if(ModelState.IsValid){
                Categoria categoria = new Categoria();
                categoria.Nome = categoriaTemporaria.Nome;
                categoria.Status = true;
                database.Categorias.Add(categoria);
                database.SaveChanges();
                return RedirectToAction("Categorias", "Gestao");
            } else {
                return View("../Gestao/NovaCategoria");
            }
        }
    }
}