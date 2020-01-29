using Microsoft.AspNetCore.Mvc;
using Waffles.Models;
using Waffles.Database;
using System.Linq;

namespace Waffles.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDBContext database;

        public FuncionariosController(ApplicationDBContext database){
            this.database = database;
        }

        public IActionResult Index(){
            var funcionarios = database.Funcionarios.ToList();
            return View(funcionarios);
        }

        public IActionResult Cadastrar(){
            return View();
        }

        public IActionResult Editar(int id){
            Funcionario funcionario = database.Funcionarios.First(registro => registro.id == id);
            return View("Cadastrar", funcionario);
        }
        
        public IActionResult Deletar(int id){
            Funcionario funcionario = database.Funcionarios.First(registro => registro.id == id);
            database.Funcionarios.Remove(funcionario);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            if(funcionario.id == 0){
                database.Funcionarios.Add(funcionario);
            }else{
                Funcionario funcionarioDoBanco = database.Funcionarios.First(registro => registro.id == funcionario.id);
                funcionarioDoBanco.nome = funcionario.nome;
                funcionarioDoBanco.salario = funcionario.salario;
                funcionarioDoBanco.cpf = funcionario.cpf;
            }
            
            
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}