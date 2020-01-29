using System;
using Microsoft.AspNetCore.Mvc;

namespace Waffles.Controllers
{
    [Route("Admin")]
    public class AdminController : Controller
    {
        [HttpGet("Index/{nome}")]
        public IActionResult Index(string nome){
            return Content("olá " + nome);
        }
        [HttpGet("batata")]
        public IActionResult batata(){
            var nome = Request.Query["nome"];
            return Content("olá " + nome);
        }

        [HttpGet("View")]
        public IActionResult visualizar(){
            return View();
        }
    }
}