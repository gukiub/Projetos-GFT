package com.br.gft;

import com.objetos.Carro;
import com.objetos.Aviao;
import com.objetos.Caminhao;

public class Main {
	public static void main(String[] args) {
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
		
		System.out.println("o carro está a " + carro.getVelocidade() + "km/h");
		System.out.println("o carro possui " + carro.getLitrosCombustivel() + " litros de gasolina");
		System.out.println("o avião está a " + aviao.getVelocidade() + "km/h");
		System.out.println("o avião possui " + aviao.getLitrosCombustivel() + " litros de gasolina");
		System.out.println("o caminhão está a " + caminhao.getVelocidade() + "km/h");
		System.out.println("o caminhão possui " + caminhao.getLitrosCombustivel() + " litros de gasolina");
	}

}
