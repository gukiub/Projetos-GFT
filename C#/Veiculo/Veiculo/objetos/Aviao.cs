using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo.objetos
{
    class Aviao : Veiculo
    {
        private String tipo;
        private String uso;
        public Aviao(string marca, string modelo, string placa, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco, String tipo, String uso) : base(marca, modelo, placa, km, isLigado, litrosCombustivel, velocidade, preco)
        {
            this.Tipo = tipo;
            this.Uso = uso;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Uso { get => uso; set => uso = value; }


		public void abastecer(String qtdLitros)
		{
			if (LitrosCombustivel >= 1000)
			{
				Console.WriteLine("Combustivel cheio");
			}
			else
			{
				if (LitrosCombustivel + int.Parse(qtdLitros) >= 1000)
				{
					Console.WriteLine("abastecido 100%");
					LitrosCombustivel = 1000;
				}
				else
				{
					LitrosCombustivel += int.Parse(qtdLitros);
				}

			}
		}



		
	public void acelerar()
		{
			if (IsLigado == true)
			{
				Velocidade += 1000;
				LitrosCombustivel -= 20;
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

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
