package com.objetos;

public class Veiculo {
	private String modelo;
	private int velocidade;
	private int litrosCombustivel;
	private String passageiros;

	public Veiculo(String modelo, int velocidade, int passageiros, int litrosCombustivel) {
		this.modelo = modelo;
		this.velocidade = velocidade;
		this.litrosCombustivel = litrosCombustivel;
		this.velocidade = velocidade;
	}

	public String getModelo() {
		return modelo;
	}

	public void setModelo(String modelo) {
		this.modelo = modelo;
	}

	public int getLitrosCombustivel() {
		return litrosCombustivel;
	}

	public void setLitrosCombustivel(int litrosCombustivel) {
		this.litrosCombustivel = litrosCombustivel;
	}

	public int getVelocidade() {
		return velocidade;
	}

	public void setVelocidade(int velocidade) {
		this.velocidade = velocidade;
	}

	public String getPassageiros() {
		return passageiros;
	}

	public void setPassageiros(String passageiros) {
		this.passageiros = passageiros;
	}

	public void abastecer(int qtdLitros) {
		if (this.litrosCombustivel >= 100) {
			System.out.println("Combustivel cheio");
		} else {
			if (this.litrosCombustivel + qtdLitros >= 100) {
				System.out.println("abastecido 100%");
				this.litrosCombustivel = 100;
			} else {
				this.litrosCombustivel += qtdLitros;
			}

		}
	}

	

}
