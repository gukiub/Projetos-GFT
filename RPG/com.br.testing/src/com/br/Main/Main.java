package com.br.Main;

import java.util.ArrayList;
import java.util.Random;

import javax.swing.JOptionPane;

import com.br.module.Berserk;
import com.br.module.Inventario;
import com.br.module.Mago;
import com.br.module.Personagem;

public class Main {

	public static void main(String[] args) {
		Berserk berserk = new Berserk();
		Mago mago = new Mago();
		String nome = "";
		String classe = "";
		int forca = 0;
		int destreza = 0;
		int agilidade = 0;
		int sorte = 0;
		int inteligencia = 0;
		int level = 0;
		int xp = 0;
		int invMin = 0;
		int expansaoInv = 0;
		ArrayList<Inventario> inventario = new ArrayList<>();
		
		
		JOptionPane.showMessageDialog(null, "Seja bem vindo ao mundo eregon!!\nCrie seu personagem agora: ");
		JOptionPane.showMessageDialog(null, "Berserker\nMago\nWarrior\nThief\nSorcery\nMonk", "Classes disponiveis", 1, null);
		try {	
			while(nome.isEmpty()) {
				nome = JOptionPane.showInputDialog(null,"qual seu nome?");
				if (nome.isEmpty()) {
					JOptionPane.showMessageDialog(null, "digite um nome.");
				}
			}
		
			while(classe.isEmpty()) {
				classe = JOptionPane.showInputDialog(null,"qual classe sua classe?").toLowerCase();
				if (classe.isEmpty()) {
					JOptionPane.showMessageDialog(null, "digite uma classe.");
				}
				
				if(classe.equals("berserker")) {
					int aux = 0;
					Random r = new Random();
					aux = r.nextInt(20);
					forca = berserk.BonusDeClasse(aux);
					aux = r.nextInt(20);
					destreza = aux;
					aux = r.nextInt(20);
					agilidade = aux;
					aux = r.nextInt(20);
					sorte = aux;
					aux = r.nextInt(20);
					inteligencia = aux;
					level = 1;
					xp = 0;
					invMin = 8;
					
				}
				
				if(classe.equals("mago")) {
					int aux = 0;
					Random r = new Random();
					aux = r.nextInt(20);
					forca = aux;
					aux = r.nextInt(20);
					destreza = aux;
					aux = r.nextInt(20);
					agilidade = aux;
					aux = r.nextInt(20);
					sorte = aux;
					aux = r.nextInt(20);
					inteligencia = mago.BonusDeClasse(aux);
					level = 1;
					xp = 0;
					invMin = 8;
				}
				
				if(classe.equals("")) {
					
				}
				
			}
			
		} catch(Exception exception) {
			System.out.println("Erro contate o administrador");
		}
		
		Personagem personagem = new Personagem(nome, forca, destreza, agilidade, sorte, classe, inteligencia, level, xp, invMin, expansaoInv, inventario);
		
		System.out.println("Atributos gerados");
		System.out.println("nome: " + personagem.getNome());
		System.out.println("classe: " + personagem.getClasse());
		System.out.println("level: " + personagem.getLevel());
		System.out.println("força: " + personagem.getForca());
		System.out.println("agilidade: " + personagem.getAgilidade());
		System.out.println("destreza: " + personagem.getDestreza());
		System.out.println("sorte: " + personagem.getSorte());
		System.out.println("inteligencia: " + personagem.getInteligencia());
		
		
	}

}
