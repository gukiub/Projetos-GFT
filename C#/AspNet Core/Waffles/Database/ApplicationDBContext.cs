using Microsoft.EntityFrameworkCore;
using Waffles.Models;
namespace Waffles.Database
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios {get; set;}
        public DbSet<Categoria> categorias {get; set;}
        public DbSet<Produto> Produtos {get; set;}
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){
        }
    }
}