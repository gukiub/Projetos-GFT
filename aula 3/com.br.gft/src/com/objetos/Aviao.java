package com.objetos;

public class Aviao extends Veiculo {
	public Aviao(String marca, String modelo, String placa, float km, boolean isLigado, int litrosCombustivel,
			int velocidade, double preco, String tipo, String uso) {
		super(marca, modelo, placa, km, isLigado, litrosCombustivel, velocidade, preco);
		this.tipo = tipo;
		this.uso = uso;
	}

	private String tipo;
	private String uso;
	

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

	public String getUso() {
		return uso;
	}

	public void setUso(String uso) {
		this.uso = uso;
	}
	
	
	public void abastecer(String qtdLitros) {
		if (litrosCombustivel >= 1000) {
			System.out.println("Combustivel cheio");
		} else {
			if (litrosCombustivel + Integer.parseInt(qtdLitros) >= 1000) {
				System.out.println("abastecido 100%");
				litrosCombustivel = 1000;
			} else {
				litrosCombustivel += Integer.parseInt(qtdLitros);
			}

		}
	}
	
	
	
	@Override
	public void acelerar() {
		if (this.isLigado == true) {
			velocidade += 1000;
			litrosCombustivel -= 20;
		} else if (this.litrosCombustivel < 1) {
			System.out.println("impossivel acelerar");
		} else {
			System.out.println("o veiculo está desligado");
		}
	}

}
