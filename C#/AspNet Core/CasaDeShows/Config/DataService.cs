using CasaDeShows.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDeShows.Config
{
    public interface IDataService
    {
        void InicializaDB();
    }

    public class DataService : IDataService
    {
        private readonly ApplicationDbContext _context;
        private readonly AdminUserContext _adminContext;

        public DataService(ApplicationDbContext context, AdminUserContext adminContext)
        {
            _context = context;
            _adminContext = adminContext;
        }

        public void InicializaDB()
        {
            // verifica se o banco está criado se ele não estiver ele cria
            _adminContext.Database.EnsureCreated();
            _context.Database.EnsureCreated();
        }
    }
}
