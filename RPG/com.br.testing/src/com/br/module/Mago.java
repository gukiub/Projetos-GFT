package com.br.module;

import interfaces.Bonus;

public class Mago implements Bonus {

	@Override
	public int BonusDeClasse(int atributo) {
		
		return atributo + 10;
	}

}
