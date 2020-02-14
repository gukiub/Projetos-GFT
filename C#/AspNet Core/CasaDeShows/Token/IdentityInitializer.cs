using CasaDeShows.Areas.Identity.Users;
using CasaDeShows.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDeShows.Token
{
    public class IdentityInitializer
    {

        private readonly AdminUserContext _context;
        private readonly UserManager<AdminUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public IdentityInitializer(
            AdminUserContext context,
            UserManager<AdminUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {
            if (_context.Database.EnsureCreated())
            {
                if (!_roleManager.RoleExistsAsync(Roles.ROLE_CASA_DE_SHOW).Result)
                {
                    var resultado = _roleManager.CreateAsync(
                        new IdentityRole(Roles.ROLE_CASA_DE_SHOW)).Result;
                    if (!resultado.Succeeded)
                    {
                        throw new Exception(
                            $"Erro durante a criação da role {Roles.ROLE_CASA_DE_SHOW}.");
                    }
                }

                CreateUser(
                    new AdminUser()
                    {
                        UserName = "admin_apialturas",
                        Email = "admin-apialturas@teste.com.br",
                        EmailConfirmed = true
                    }, "AdminAPIAlturas01!", Roles.ROLE_CASA_DE_SHOW);

                CreateUser(
                    new AdminUser()
                    {
                        UserName = "usrinvalido_apialturas",
                        Email = "usrinvalido-apialturas@teste.com.br",
                        EmailConfirmed = true
                    }, "UsrInvAPIAlturas01!");
            }
        }

        private void CreateUser(
            AdminUser user,
            string password,
            string initialRole = null)
        {
            if (_userManager.FindByNameAsync(user.UserName).Result == null)
            {
                var resultado = _userManager
                    .CreateAsync(user, password).Result;

                if (resultado.Succeeded &&
                    !String.IsNullOrWhiteSpace(initialRole))
                {
                    _userManager.AddToRoleAsync(user, initialRole).Wait();
                }
            }
        }


    }
}
