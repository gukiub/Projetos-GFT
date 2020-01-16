using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo.objetos
{
    class Caminhao : Veiculo
    {
        private double tamanho;
        private String carga;

        public Caminhao(string marca, string modelo, string placa, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco, double tamanho, String carga) : base(marca, modelo, placa, km, isLigado, litrosCombustivel, velocidade, preco)
        {
            this.Tamanho = tamanho;
            this.Carga = carga;
        }

		public double Tamanho { get => tamanho; set => tamanho = value; }
		public string Carga { get => carga; set => carga = value; }

		public void abastecer(float qtdLitros)
		{
			if (LitrosCombustivel >= 150)
			{
				Console.WriteLine("Combustivel cheio");
			}
			else
			{
				if (LitrosCombustivel + qtdLitros >= 150)
				{
					Console.WriteLine("abastecido 100%");
					LitrosCombustivel = 150;
				}
				else
				{
					LitrosCombustivel += (int) qtdLitros;
				}

			}
		}

	public void acelerar()
		{
			if (IsLigado == true)
			{
				Velocidade += 25;
				LitrosCombustivel -= 5;
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
