using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using teste.Models;

namespace teste.Context
{
    public class Aula1Context : DbContext
    {
        public Aula1Context() 
            : base("conn")
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}