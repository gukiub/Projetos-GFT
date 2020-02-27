using APIrest.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIrest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok(new {nome = "asdasd", empresa = "teste"}); // Status code = 200 && dados
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id){
            return Ok("eu e um numero " + id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProdutoTemp pTemp){
            return Ok(new {info = "você cadastrou um json ", produto = pTemp});
        }




        public class ProdutoTemp{
            public string Nome { get; set; }
            public float Preco { get; set; }
        }
    }
}