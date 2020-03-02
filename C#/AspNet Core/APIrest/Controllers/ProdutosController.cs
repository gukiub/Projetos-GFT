using System;
using System.Linq;
using APIrest.Data;
using APIrest.Models;
using Microsoft.AspNetCore.Mvc;
using APIrest.HATEOAS;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace APIrest.Controllers
{
    [Route("api/v1/[controller]")] // versão legado - versão sem suporte
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class ProdutosController : ControllerBase
    {
        readonly ApplicationDbContext _context;
        private HATEOAS.HATEOAS HATEOAS;

        public ProdutosController(ApplicationDbContext context)
        {
            _context = context;
            HATEOAS = new HATEOAS.HATEOAS("localhost:5001/api/v1/Produtos");
            HATEOAS.AddAction("GET_INFO", "GET");
            HATEOAS.AddAction("DELETE_PRODUCT", "DELETE");
            HATEOAS.AddAction("EDIT_PRODUCT", "PATCH");
        }

        [HttpGet("teste")]
        public IActionResult TesteClaims(){
            return Ok(HttpContext.User.Claims.First(claim => claim.Type.ToString().Equals("id", StringComparison.InvariantCultureIgnoreCase)).Value);
        }

        [HttpGet]
        public IActionResult Get(){
            var produtos = _context.Produtos.ToList();
            List<ProdutoContainer> produtosHATEOAS = new List<ProdutoContainer>();
            foreach(var prod in produtos){
                ProdutoContainer produtoHATEOAS = new ProdutoContainer();
                produtoHATEOAS.produto = prod;
                produtoHATEOAS.links = HATEOAS.GetActions(prod.Id.ToString());
                produtosHATEOAS.Add(produtoHATEOAS);
            }
            return Ok(produtosHATEOAS); // Status code = 200 && dados
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id){
            try
            {
                var produto = _context.Produtos.First(p => p.Id == id);
                ProdutoContainer produtoHATEOAS = new ProdutoContainer();
                produtoHATEOAS.produto = produto;
                produtoHATEOAS.links = HATEOAS.GetActions(produto.Id.ToString());
                return Ok(produtoHATEOAS);
            }
            catch (Exception)
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

            if(pTemp.Nome == null){
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
            catch (Exception)
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
                catch (Exception)
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

        public class ProdutoContainer{
            public Produto produto {get; set;}
            public Link[] links {get; set;}
        }
    }
}