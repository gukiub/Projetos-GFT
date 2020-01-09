package com.objetos;

public class Carro extends Veiculo {
	public Carro(String marca, String modelo, String placa, float km, boolean isLigado,
			int litrosCombustivel, int velocidade, double preco, int portas, int ano) {
		super(marca, modelo, placa, km, isLigado, litrosCombustivel, velocidade, preco);
		this.portas = portas;
		this.ano = ano;
	}
	private int portas;
	private int ano;
	
	
	public int getPortas() {
		return portas;
	}
	public void setPortas(int portas) {
		this.portas = portas;
	}
	public int getAno() {
		return ano;
	}
	public void setAno(int ano) {
		this.ano = ano;
	}
	
	@Override
	public void acelerar() {
		if (this.isLigado == true) {
			velocidade += 50;
			litrosCombustivel -= 1;
		} else if (this.litrosCombustivel < 1) {
			System.out.println("impossivel acelerar");
		} else {
			System.out.println("o veiculo está desligado");
		}
	}
	
	
	
	
}
	
