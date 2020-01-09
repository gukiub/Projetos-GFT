package com.objetos;

public class Caminhao extends Veiculo{
	private double tamanho;
	private String carga;
	public Caminhao(String marca, String modelo, String placa, float km, boolean isLigado, int litrosCombustivel,
			int velocidade, double preco, double tamanho, String carga) {
		super(marca, modelo, placa, km, isLigado, litrosCombustivel, velocidade, preco);
		this.tamanho = tamanho;
		this.carga = carga;
	}
	
	
	public double getTamanho() {
		return tamanho;
	}
	public void setTamanho(double tamanho) {
		this.tamanho = tamanho;
	}
	public String getCarga() {
		return carga;
	}
	public void setCarga(String carga) {
		this.carga = carga;
	}

	
	
	public void abastecer(float qtdLitros) {
		if (litrosCombustivel >= 150) {
			System.out.println("Combustivel cheio");
		} else {
			if (litrosCombustivel + qtdLitros >= 150) {
				System.out.println("abastecido 100%");
				litrosCombustivel = 150;
			} else {
				litrosCombustivel += qtdLitros;
			}

		}
	}
	
	@Override
	public void acelerar() {
		if (this.isLigado == true) {
			velocidade += 25;
			litrosCombustivel -= 5;
		} else if (this.litrosCombustivel < 1) {
			System.out.println("impossivel acelerar");
		} else {
			System.out.println("o veiculo está desligado");
		}
	}
	
}
