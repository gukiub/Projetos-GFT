using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using CasaDeShows.Models;
using CasaDeShows.Token;
using CasaDeShows.Data;
using CasaDeShows.Areas.Identity.Users;

namespace CasaDeShows.Controllers
{

    //[Route("api")]
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _ctx;
        private readonly UserManager<AdminUser> _userManager;

        public LoginController(ApplicationDbContext ctx, UserManager<AdminUser> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }

        [AllowAnonymous]
        [Route("api/Login/{email}/{senha}")]
        [HttpGet]
        public IActionResult Post(
            //[FromBody]User usuario,
            [FromRoute] string email,
            [FromRoute] string senha,
            [FromServices]UserManager<AdminUser> userManager,
            [FromServices]SignInManager<AdminUser> signInManager,
            [FromServices]SigningConfigurations signingConfigurations,
            [FromServices]TokenConfigurations tokenConfigurations)
        {
            bool credenciaisValidas = false;
            if (email != null && !String.IsNullOrWhiteSpace(email))
            {
                // Verifica a existência do usuário nas tabelas do
                // ASP.NET Core Identity
                var userIdentity = userManager
                    .FindByNameAsync(email).Result;
                if (userIdentity != null)
                {
                    // Efetua o login com base no Id do usuário e sua senha
                    var resultadoLogin = signInManager
                        .CheckPasswordSignInAsync(userIdentity, senha, false)
                        .Result;
                    if (resultadoLogin.Succeeded)
                    {
                        // Verifica se o usuário em questão possui
                        // a role Acesso-APIAlturas
                        credenciaisValidas = userManager.IsInRoleAsync(
                            userIdentity, Roles.ROLE_CASA_DE_SHOW).Result;
                    }
                }
            }

            if (credenciaisValidas)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                    new GenericIdentity(email, "Login"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, email)
                    }
                );

                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao +
                    TimeSpan.FromDays(tokenConfigurations.Days);

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao
                });

                var token = handler.WriteToken(securityToken);

                Chave novaChave = new Chave()
                {
                    Authenticated = true,
                    Created = dataCriacao,
                    Expiration = dataExpiracao,
                    Token = token,
                    Message = "OK",
                };

                var usuario = _ctx.Usuarios.Where(u => u.Email.Equals(email))
                    .Include(a => a.Chave)
                    .FirstOrDefault();

                if (usuario.Chave == null)
                {
                    usuario.Chave = novaChave;
                    _ctx.Attach(usuario).State = EntityState.Modified;
                    _ctx.SaveChanges();
                }

                if (novaChave.Token != usuario.Chave.Token)
                {
                    usuario.Chave = novaChave;
                    _ctx.Attach(usuario).State = EntityState.Modified;
                    _ctx.SaveChanges();
                }

                string returnUrl = Url.Content("~/Admin/Index/");

                return LocalRedirect(returnUrl);

            }
            else
            {
                return Unauthorized();
            }
        }

        [AllowAnonymous]
        [Route("v1/Login/GetToken")]
        [HttpPost]
        public async Task<IActionResult> GetToken(string email, string senha,
            [FromServices]UserManager<AdminUserContext> userManager,
            [FromServices]SignInManager<AdminUserContext> signInManager,
            [FromServices]SigningConfigurations signingConfigurations,
            [FromServices]TokenConfigurations tokenConfigurations)
        {

            var watch = new Stopwatch();
            watch.Start();

            bool credenciaisValidas = false;

            // Verifica a existência do usuário nas tabelas do
            // ASP.NET Core Identity
            var userIdentity = userManager
                .FindByNameAsync(email).Result;
            if (userIdentity != null)
            {
                // Efetua o login com base no Id do usuário e sua senha
                var resultadoLogin = signInManager
                    .CheckPasswordSignInAsync(userIdentity, senha, false)
                    .Result;
                if (resultadoLogin.Succeeded)
                {
                    // Verifica se o usuário em questão possui
                    // a role Acesso-APIAlturas
                    credenciaisValidas = userManager.IsInRoleAsync(
                        userIdentity, Roles.ROLE_CASA_DE_SHOW).Result;
                }
            }

            if (credenciaisValidas)
            {
                //Chave chave = _ctx.Usuarios.Where(u => u.Email.Equals(email)).FirstOrDefault().Chave;

                if (chave == null || chave.Token == "")
                {
                    ClaimsIdentity identity = new ClaimsIdentity(
                        new GenericIdentity(email, "Login"),
                        new[] {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                            new Claim(JwtRegisteredClaimNames.UniqueName, email)
                        }
                    );

                    DateTime dataCriacao = DateTime.Now;
                    DateTime dataExpiracao = dataCriacao +
                        TimeSpan.FromDays(tokenConfigurations.Days);

                    var handler = new JwtSecurityTokenHandler();
                    var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                    {
                        Issuer = tokenConfigurations.Issuer,
                        Audience = tokenConfigurations.Audience,
                        SigningCredentials = signingConfigurations.SigningCredentials,
                        Subject = identity,
                        NotBefore = dataCriacao,
                        Expires = dataExpiracao
                    });

                    var token = handler.WriteToken(securityToken);

                    Chave novaChave = new Chave()
                    {
                        Authenticated = true,
                        Created = dataCriacao,
                        Expiration = dataExpiracao,
                        Token = token,
                        Message = "OK",
                    };

                    var usuario = _ctx.Usuarios.Where(u => u.Email.Equals(email))
                        .Include(a => a.Chave)
                        .FirstOrDefault();

                    if (usuario.Chave == null)
                    {
                        usuario.Chave = novaChave;
                        _ctx.Attach(usuario).State = EntityState.Modified;
                        _ctx.SaveChanges();
                    }

                    if (novaChave.Token != usuario.Chave.Token)
                    {
                        usuario.Chave = novaChave;
                        _ctx.Attach(usuario).State = EntityState.Modified;
                        _ctx.SaveChanges();
                    }

                    chave = novaChave;
                }

                LoginTokenDTO loginToken = new LoginTokenDTO
                {
                    DataCriacao = chave.Created,
                    DataExpiracao = chave.Expiration,
                    Token = chave.Token
                };

                watch.Stop();
                var TempoRequisicao = watch.ElapsedMilliseconds;
                
                return Ok(loginToken);
            }
            else
            {
                watch.Stop();
                var TempoRequisicao = watch.ElapsedMilliseconds;

                return StatusCode(401, "Usuario ou senha invalidas");
            }

        }

        //private async Task LogRequest(string Usuario, string Endpoint, long TempoRequisicao)
        //{
        //    await _serv.LogRequest(Usuario, Endpoint, TempoRequisicao);
        //}
    }
}