using System;

namespace CasaDeShows.Models
{
    public class Eventos
    { 
        public int Id { get; set; }
        public string Nome { get; set; }
        public CasasDeShow CasaDeShows { get; set; }
        public double Preco { get; set; }
        public int Genero { get; set; }
        public DateTime Data { get; set; }
        public int Ingressos { get; set; }
        public string Imagem { get; set; }
    }
}