using System;

namespace CasaDeShows.Models
{
    public class Eventos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public CasasDeShow CasaDeShows { get; set; }
        public double Preco { get; set; }
        public Generos Genero { get; set; }
        public DateTime data { get; set; }
        public int Ingressos { get; set; }
    }
}