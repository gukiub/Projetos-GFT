using CasaDeShows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDeShows.DTO
{
    public class EventoDTO
    {
        public string Nome { get; set; }
        public string CasaDeShowsId { get; set; }
        public string Preco { get; set; }
        public DateTime Data { get; set; }
        public string Ingressos { get; set; }
    }
}
