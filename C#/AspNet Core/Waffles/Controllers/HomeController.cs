using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Waffles.Database;
using Waffles.Models;
using Microsoft.EntityFrameworkCore;

namespace Waffles.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDBContext database;
        
        public HomeController(ApplicationDBContext database){
            this.database = database;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teste(){
            /*Categoria c1 = new Categoria();
            c1.nome = "Victor";
            Categoria c2 = new Categoria();
            c2.nome = "Victor";
            Categoria c3 = new Categoria();
            c3.nome = "Erik";
            Categoria c4 = new Categoria();
            c4.nome = "Lucas";

            List<Categoria> catList = new List<Categoria>();
            catList.Add(c1);
            catList.Add(c2);
            catList.Add(c3);
            catList.Add(c4);

            database.AddRange(catList);
            database.SaveChanges();
            */

            var listaDeCategorias =  database.categorias.Where(cat => cat.nome.Equals("Victor")).ToList();
            
            Console.WriteLine("============ Categorias ==============");

            listaDeCategorias.ForEach(categoria => {
                Console.WriteLine(categoria.ToString());
            });


            Console.WriteLine("======================================");

            return Content("dados salvos");
        }

        public IActionResult Relacionamento(){
            /*Produto p1 = new Produto();
            p1.nome = "Doritos";
            p1.categoria = database.categorias.First(c => c.id == 1);

            Produto p2 = new Produto();
            p2.nome = "Frango";
            p2.categoria = database.categorias.First(c => c.id == 1);

            Produto p3 = new Produto();
            p3.nome = "Bolo";
            p3.categoria = database.categorias.First(c => c.id == 2);

            database.Add(p1);
            database.Add(p2);
            database.Add(p3);

            database.SaveChanges();
            */
            /*
            var listaDeProdutos = database.Produtos.Include(p => p.categoria).ToList();

            listaDeProdutos.ForEach(produto => {
                Console.WriteLine(produto.ToString());
            });
            */

            var listaDeProdutosDeUmaCategoria = database.Produtos.Include(p => p.categoria).Where(p => p.categoria.id == 1).ToList();

            listaDeProdutosDeUmaCategoria.ForEach(produto => {
                Console.WriteLine(produto.ToString());
            });


            return Content("Relacionamento");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
