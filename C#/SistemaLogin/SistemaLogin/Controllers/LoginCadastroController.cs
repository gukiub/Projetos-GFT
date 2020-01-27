using SistemaLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SistemaLogin.Controllers
{
    public class LoginCadastroController : Controller
    {
        LoginEntities ctx = new LoginEntities();
        // GET: LoginCadastro
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(login usuario) 
        {
            var senhaCrip = FormsAuthentication.HashPasswordForStoringInConfigFile(usuario.senha, "MD5");
            usuario.senha = senhaCrip;

            var consultaUsuario = ctx.login.Where(u => u.login_email == usuario.login_email && u.senha == senhaCrip).FirstOrDefault();

            if (consultaUsuario != null)
            {
                Session.Add("usuario", consultaUsuario);
                return Redirect("/Adm/Index");
            }
            else 
            {
                ViewBag.ErroAutenticacao = "Usuário ou senha inválidos.";
                return View("Index");
            }
        }
        [HttpPost]
        public ActionResult CadastroUsuario(login novoUsuario)
        {
            var senhaCrip = FormsAuthentication.HashPasswordForStoringInConfigFile(novoUsuario.senha, "MD5");
            novoUsuario.senha = senhaCrip;
            novoUsuario.data_cadastro = DateTime.Now;
            ctx.login.Add(novoUsuario);
            ctx.SaveChanges();
            ViewBag.StatusCadastro = "Usuário cadastrado com sucesso.";
            return View("Index");
        }

        [HttpPost]
        public ActionResult FinalizarSessao()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
    }
}