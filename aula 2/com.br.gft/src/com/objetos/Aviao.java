package com.objetos;

public class Aviao extends Veiculo {
	private String tipo;
	private String uso;
	
	public Aviao(String modelo, int velocidade, int passageiros, int litrosCombustivel, String tipo, String uso) {
		super(modelo, velocidade, passageiros, litrosCombustivel);
		this.tipo = tipo;
		this.uso = uso;
	}

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

	

}
