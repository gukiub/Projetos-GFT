using System;
using Veiculo.objetos;

namespace Veiculo
{
    class @namespace
    {
        static void Main(string[] args)
        {
			Carro carro = new Carro("marca", "modelo", "placa", 50, false, 20, 0, 50000, 4, 2020);
			Aviao aviao = new Aviao("marca", "modelo", "placa", 1000, false, 20, 0, 1000000, "jato", "particular");
			Caminhao caminhao = new Caminhao("marca", "modelo", "placa", 1000, false, 10, 0, 25000, 2, "carga");

			carro.ligar();
			carro.acelerar();
			carro.abastecer(10);
			aviao.ligar();
			aviao.abastecer("99");
			aviao.acelerar();
			caminhao.ligar();
			caminhao.acelerar();
			caminhao.abastecer(50f);

			Console.WriteLine("o carro está a " + carro.Velocidade + "km/h");
			Console.WriteLine("o carro possui " + carro.LitrosCombustivel + " litros de gasolina");
			Console.WriteLine("o avião está a " + aviao.Velocidade + "km/h");
			Console.WriteLine("o avião possui " + aviao.LitrosCombustivel + " litros de gasolina");
			Console.WriteLine("o caminhão está a " + caminhao.Velocidade + "km/h");
			Console.WriteLine("o caminhão possui " + caminhao.LitrosCombustivel + " litros de gasolina");
		}
    }
}
