using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDeShows.Models;
using Microsoft.AspNetCore.Identity;

namespace CasaDeShows.Areas.Identity.Users
{
    // Add profile data for application users by adding properties to the MilenioRadartonaAPIUser class
    public class AdminUser : IdentityUser
    {
        //virar colunas do aspnet users
        public int Nome { get; set; }
        public Chave Chave { get; set; }
    }
}
