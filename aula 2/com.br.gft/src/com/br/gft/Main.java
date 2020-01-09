package com.br.gft;

import com.objetos.Carro;
import com.objetos.Aviao;

public class Main {

	public static void main(String[] args) {
		Carro carro = new Carro("camaro", 200, 2, 100, "chevrolet", 2, 2015);
		Aviao aviao = new Aviao("jumbo", 890, 50, 2000, "aeronave", "particular");
		
		carro.setAno(2000);
		aviao.setUso("publico");
		
		System.out.println(aviao.getPassageiros());
	}

}
