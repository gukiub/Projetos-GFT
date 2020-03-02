using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using APIrest.Data;
using APIrest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace APIrest.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        //api/v1/usuarios/registro
        [HttpPost("registro")]
        public IActionResult Registro([FromBody] Usuario usuario)
        {
            // verificar se as credenciais são validas
            // verificar se o e-mail já está cadastrado no banco
            // Encriptar a senha

            // api salvando direto

            _context.Add(usuario);
            _context.SaveChanges();
            return Ok(new {msg="Usuário cadastrado com sucesso"});
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] Usuario credenciais){
            // Buscar um usuário por e-mail
            // Verificar se a senha está correta
            // Gerar um token JWT e retornar esse token para o usuário
            
            try{
                Usuario usuario = _context.Usuarios.First(user => user.Email.Equals(credenciais.Email));
                if(usuario != null){
                    // Achou um usuário com cadastro valido
                    if (usuario.Senha.Equals(credenciais.Senha)){
                        // Usuário acertou a senha

                        string ChaveDeSeguranca = "eu_gosto_de_batata_e_lasagna"; // Chave de segurança
                        var chaveSimetrica = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ChaveDeSeguranca));
                        var credenciaisDeAcesso = new SigningCredentials(chaveSimetrica, SecurityAlgorithms.HmacSha256Signature);
                        

                        var claims = new List<Claim>();
                        claims.Add(new Claim("id", usuario.Id.ToString()));
                        claims.Add(new Claim("email", usuario.Email));
                        claims.Add(new Claim(ClaimTypes.Role, "Admin"));



                        var JWT = new JwtSecurityToken(
                            issuer: "Batata", //Quem está fornecendo o Jwt para o user
                            expires: DateTime.Now.AddHours(1), //Tempo de sessão
                            audience: "Pessoas_normais", // a audiencia
                            signingCredentials: credenciaisDeAcesso, // credenciais de acesso do token
                            claims: claims
                        );

                        return Ok(new JwtSecurityTokenHandler().WriteToken(JWT));

                    } else {
                        // Não existe nenhum usuário com este e-mail
                        Response.StatusCode = 401; // Não autorizado
                        return new ObjectResult("");
                    }
                } else {
                    // Não existe nenhum usuário com este e-mail
                    Response.StatusCode = 401; // Não autorizado
                    return new ObjectResult("");
                }
            } catch (Exception){
                // Não existe nenhum usuário com este e-mail
                Response.StatusCode = 401; // Não autorizado
                return new ObjectResult("");
            }
        }
    }
}