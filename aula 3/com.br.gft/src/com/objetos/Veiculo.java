package com.objetos;

public abstract class Veiculo {
	public String marca;
	protected String modelo;
	protected String placa;
	protected float km;
	protected boolean isLigado;
	protected int litrosCombustivel;
	protected int velocidade;
	protected double preco;

	public Veiculo(String marca, String modelo, String placa, float km, boolean isLigado,
			int litrosCombustivel, int velocidade, double preco) {
		this.marca = marca;
		this.modelo = modelo;
		this.placa = placa;
		this.km = km;
		this.isLigado = isLigado;
		this.litrosCombustivel = litrosCombustivel;
		this.velocidade = velocidade;
		this.preco = preco;
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

	public String getMarca() {
		return marca;
	}

	public void setMarca(String marca) {
		this.marca = marca;
	}

	public String getPlaca() {
		return placa;
	}

	public void setPlaca(String placa) {
		this.placa = placa;
	}


	public float getKm() {
		return km;
	}

	public void setKm(float km) {
		this.km = km;
	}

	public boolean isLigado() {
		return isLigado;
	}

	public void setLigado(boolean isLigado) {
		this.isLigado = isLigado;
	}

	public double getPreco() {
		return preco;
	}

	public void setPreco(double preco) {
		this.preco = preco;
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

	public void acelerar() {
		if (this.isLigado == true) {
			velocidade += 20;
			litrosCombustivel -= 1;
		} else if (this.litrosCombustivel <= 0) {
			System.out.println("impossivel acelerar");
		} else {
			System.out.println("o veiculo está desligado");
		}
	}

	public void frear() {
		if (this.isLigado == true && this.velocidade > 0) {
			this.velocidade -= 10;
		} else {
			System.out.println("o veiculo está desligado");
		}
	}


	public void ligar() {
		if (this.isLigado == true) {
			System.out.println("o veiculo já está ligado");
		} else {
			this.isLigado = true;
			System.out.println("você ligou o veiculo");
		}
	}

	
	public void desligar() {
		if (this.isLigado == false) {
			System.out.println("o veiculo já está desligado");
		} else {
			this.isLigado = false;
			System.out.println("você desligou o veiculo");
		}
	}

}
