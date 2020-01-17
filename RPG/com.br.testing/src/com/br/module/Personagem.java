package com.br.module;

import java.util.ArrayList;

public class Personagem {
	protected String nome;
	protected int forca;
	protected int destreza;
	protected int agilidade;
	protected int sorte;
	protected String classe;
	protected int inteligencia;
	protected int level;
	protected int xp;
	protected int invMin;
	protected int expansaoInv;
	ArrayList<Inventario> inventario = new ArrayList<>();
	
	public Personagem(String nome, int forca, int destreza, int agilidade, int sorte, String classe, int inteligencia, int level, int xp, int invMin, int expansaoInv, ArrayList<Inventario> inventario) {
		this.nome = nome;
		this.forca = forca;
		this.destreza = destreza;
		this.agilidade = agilidade;
		this.sorte = sorte;
		this.classe = classe;
		this.inteligencia = inteligencia;
		this.level = level;
		this.xp = xp;
		this.invMin = invMin;
		this.expansaoInv = expansaoInv;
		this.inventario = inventario;
	}
	
	
	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public int getForca() {
		return forca;
	}

	public void setForca(int forca) {
		this.forca = forca;
	}

	public int getDestreza() {
		return destreza;
	}

	public void setDestreza(int destreza) {
		this.destreza = destreza;
	}

	public int getAgilidade() {
		return agilidade;
	}

	public void setAgilidade(int agilidade) {
		this.agilidade = agilidade;
	}

	public int getSorte() {
		return sorte;
	}

	public void setSorte(int sorte) {
		this.sorte = sorte;
	}

	public int getInteligencia() {
		return inteligencia;
	}

	public void setInteligencia(int inteligencia) {
		this.inteligencia = inteligencia;
	}

	public int getLevel() {
		return level;
	}

	public void setLevel(int level) {
		this.level = level;
	}

	public int getXp() {
		return xp;
	}

	public void setXp(int xp) {
		this.xp = xp;
	}

	public int getInvMin() {
		return invMin;
	}

	public void setInvMin(int invMin) {
		this.invMin = invMin;
	}

	public int getExpansaoInv() {
		return expansaoInv;
	}

	public void setExpansaoInv(int expansaoInv) {
		this.expansaoInv = expansaoInv;
	}

	public ArrayList<Inventario> getInventario() {
		return inventario;
	}

	public void setInventario(ArrayList<Inventario> inventario) {
		this.inventario = inventario;
	}

	public String getClasse() {
		return classe;
	}

	public void setClasse(String classe) {
		this.classe = classe;
	}
	
	
}
