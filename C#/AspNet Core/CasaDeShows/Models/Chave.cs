using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDeShows.Models
{
    public class Chave
    {
        public int ChaveId { get; set; }
        public string Token { get; set; }
        public bool Authenticated { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expiration { get; set; }
    }
}
