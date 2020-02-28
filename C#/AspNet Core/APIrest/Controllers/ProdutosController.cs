using System;
using System.Linq;
using APIrest.Data;
using APIrest.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIrest.Controllers
{
    [Route("api/v1/[controller]")] // versão legado - versão sem suporte
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        readonly ApplicationDbContext _context;

        public ProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(){
            var produtos = _context.Produtos.ToList();
            return Ok(produtos); // Status code = 200 && dados
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id){
            try
            {
                var produto = _context.Produtos.First(p => p.Id == id);
                return Ok(produto);
            }
            catch (Exception e)
            {
                Response.StatusCode = 404;
                return new ObjectResult("");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProdutoTemp pTemp){
            /*validação*/
            if(pTemp.Preco <= 0){
                Response.StatusCode = 400;
                return new ObjectResult(new {msg = "O preço do produto não pode ser menor que zero ou igual a zero."});
            }

            if(pTemp.Nome.Length <= 1){
                Response.StatusCode = 400;
                return new ObjectResult(new {msg = "O nome do produto precisa conter mais de 1 caracter."});
            }
            
            Produto p = new Produto();
            p.Nome = pTemp.Nome;
            p.Preco = pTemp.Preco;
            _context.Produtos.Add(p);
            _context.SaveChanges();

            Response.StatusCode = 201;
            return new ObjectResult("");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            try
            {
                var produto = _context.Produtos.First(p => p.Id == id);
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                Response.StatusCode = 404;
                return new ObjectResult("");
            }
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] Produto produto){
            if (produto.Id > 0){
                try
                {
                    var p = _context.Produtos.First(ptemp => ptemp.Id == produto.Id);

                    if(p != null){
                        
                        //editar 
                        //operador ternario: condição ? faz algo : faz outra coisa
                        p.Nome = produto.Nome != null ? produto.Nome : p.Nome;
                        p.Preco = produto.Preco != 0 ? produto.Preco : p.Preco;

                        _context.SaveChanges();
                        return Ok();

                    } else {
                        Response.StatusCode = 400;
                        return new ObjectResult(new {msg = "Produto não encontrado"});
                    }
                }
                catch (Exception e)
                {
                    Response.StatusCode = 400;
                    return new ObjectResult(new {msg = "Produto não encontrado"});
                }
                
            }else {
                Response.StatusCode = 400;
                return new ObjectResult(new {msg = "O Id do Produto é invalido"});
            }
        }

        //SWAGGER
        


        public class ProdutoTemp{
            public string Nome { get; set; }
            public float Preco { get; set; }
        }
    }
}