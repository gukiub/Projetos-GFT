using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadao.objetos
{
    class VideoGame : Produto
    {
        private String marca;
        private String modelo;
        private bool isUsado;

        public VideoGame(string nome, double preco, int qtd, String marca, String modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }


        public String Marca { get { return this.marca; } set { this.marca = value; } }
        public String Modelo { get { return this.modelo; } set { this.modelo = value; } }
        public bool IsUsado { get { return this.isUsado; } set { this.isUsado = value; } }



        public double calculaImposto()
        {
            if (isUsado == true)
            {
                double aux = 0;
                aux = Preco * 0.25;
                Console.WriteLine("Imposto " + Nome + " " + modelo + " usado, R$ " + aux);
                return Preco;
            }
            else
            {
                double aux = 0;
                aux = Preco * 0.45;
                Console.WriteLine("Imposto " + Nome + " " + modelo + " R$ " + aux);
                return Preco;
            }
        }

        public override void produto()
        {
        }
    }
}
