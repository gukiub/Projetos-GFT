using System.Collections.Generic;

namespace CasaDeShows.Models
{
    public class CasasDeShow
    {
        public int Id{get; set;}
        public string Nome{get;set;}
        public int Capacidade{get;set;}
        public string Bandas{get;set;}
        public int IngressosDisp{get;set;}
        public string Local{get;set;}
        public bool Status{get;set;}
    }
}