using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teste.Models;
using teste.Context;

namespace teste.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Teste()
        {
            var cliente = new Aula1Context().Clientes.SingleOrDefault(c => c.Id == 1);

            ViewBag.Cliente = "Texto";
            //ViewData["Cliente"] = cliente;


            return View("Index", cliente);
        }

        public ActionResult Lista() 
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() {Nome = "Joao", SobreNome = "Pedro", DataCadastro = DateTime.Now, Id = 1},
                new Cliente() {Nome = "Fulano", SobreNome = "Betrano", DataCadastro = DateTime.Now, Id = 2},
            };
            return View(listaClientes);
        }

        public ActionResult Pesquisa(int? id, string nome)
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() {Nome = "Joao", SobreNome = "Pedro", DataCadastro = DateTime.Now, Id = 1},
                new Cliente() {Nome = "Fulano", SobreNome = "Betrano", DataCadastro = DateTime.Now, Id = 2},
                new Cliente() {Nome = "zé", SobreNome = "batata", DataCadastro = DateTime.Now, Id = 3},
                new Cliente() {Nome = "Jessica", SobreNome = "mendes", DataCadastro = DateTime.Now, Id = 4}
            };

            var cliente = listaClientes.Where(c => c.Id == id).ToList();

            if (!cliente.Any()) 
            {
                TempData["Erro"] = "nenhum cliente selecionado";
                return RedirectToAction("ErroPesquisa");
            }

            return View("Lista", cliente);
        }


        public ActionResult ErroPesquisa() 
        {
            return View("Error");
        }
    }
}