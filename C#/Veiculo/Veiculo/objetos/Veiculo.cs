using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo.objetos
{
    abstract class Veiculo
    {
		private String marca;
		private String modelo;
		private String placa;
		private float km;
		private bool isLigado;
		private int litrosCombustivel;
		private int velocidade;
		private double preco;

		public Veiculo(String marca, String modelo, String placa, float km, bool isLigado,
			int litrosCombustivel, int velocidade, double preco)
		{
			this.Marca = marca;
			this.Modelo = modelo;
			this.Placa = placa;
			this.Km = km;
			this.IsLigado = isLigado;
			this.LitrosCombustivel = litrosCombustivel;
			this.Velocidade = velocidade;
			this.Preco = preco;
		}


		public string Marca { get => marca; set => marca = value; }
		public string Modelo { get => modelo; set => modelo = value; }
		public string Placa { get => placa; set => placa = value; }
		public float Km { get => km; set => km = value; }
		public bool IsLigado { get => isLigado; set => isLigado = value; }
		public int LitrosCombustivel { get => litrosCombustivel; set => litrosCombustivel = value; }
		public int Velocidade { get => velocidade; set => velocidade = value; }
		public double Preco { get => preco; set => preco = value; }

		public void abastecer(int qtdLitros)
		{
			if (this.litrosCombustivel >= 100)
			{
				Console.WriteLine("Combustivel cheio");
			}
			else
			{
				if (this.litrosCombustivel + qtdLitros >= 100)
				{
					Console.WriteLine("abastecido 100%");
					this.litrosCombustivel = 100;
				}
				else
				{
					this.litrosCombustivel += qtdLitros;
				}

			}
		}

		public void acelerar()
		{
			if (this.isLigado == true)
			{
				velocidade += 20;
				litrosCombustivel -= 1;
			}
			else if (this.litrosCombustivel <= 0)
			{
				Console.WriteLine("impossivel acelerar");
			}
			else
			{
				Console.WriteLine("o veiculo está desligado");
			}
		}

		public void frear()
		{
			if (this.isLigado == true && this.velocidade > 0)
			{
				this.velocidade -= 10;
			}
			else
			{
				Console.WriteLine("o veiculo está desligado");
			}
		}


		public void ligar()
		{
			if (this.isLigado == true)
			{
				Console.WriteLine("o veiculo já está ligado");
			}
			else
			{
				this.isLigado = true;
				Console.WriteLine("você ligou o veiculo");
			}
		}


		public void desligar()
		{
			if (this.isLigado == false)
			{
				Console.WriteLine("o veiculo já está desligado");
			}
			else
			{
				this.isLigado = false;
				Console.WriteLine("você desligou o veiculo");
			}
		}
	}
}
