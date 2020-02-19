using System;
using System.Collections.Generic;
using System.Text;
using CasaDeShows.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CasaDeShows.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<CasasDeShow> casasDeShow {get; set;}
        public DbSet<Eventos> Eventos {get; set;}


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Eventos>().HasIndex(eve => eve.Nome).IsUnique();
            builder.Entity<CasasDeShow>().HasIndex(eve => eve.Nome).IsUnique();
        }
    }
}
