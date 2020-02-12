using System;
using System.Collections.Generic;

namespace CasaDeShows.Models
{
    public class Eventos
    {
        public int Id {get; set;}
        public string Nome{get; set;}
        public double Preco{get; set;}
        public DateTime Data{get; set;}
        public CasasDeShow Local{get; set;}
        public Bandas Banda{get; set;}
        public List<CasasDeShow> IngressosDisp {get; set;}

    }
}