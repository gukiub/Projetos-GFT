using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo.objetos
{
    class Carro : Veiculo
    {
        private int portas;
        private int ano;

        public Carro(string marca, string modelo, string placa, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco, int portas, int ano) : base(marca, modelo, placa, km, isLigado, litrosCombustivel, velocidade, preco)
        {
            this.Portas = portas;
            this.Ano = ano;
        }

        public int Portas { get => portas; set => portas = value; }
        public int Ano { get => ano; set => ano = value; }

        public void acelerar()
        {
            if (IsLigado == true)
            {
                Velocidade += 50;
                LitrosCombustivel -= 1;
            }
            else if (LitrosCombustivel < 1)
            {
                Console.WriteLine("impossivel acelerar");
            }
            else
            {
                Console.WriteLine("o veiculo está desligado");
            }
        }
    }
}
