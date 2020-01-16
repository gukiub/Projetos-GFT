package br.com.gft.model;

import java.util.ArrayList;

public class Loja {
	private String nome;
	private String cnpj;
	ArrayList<Livro> livros = new ArrayList();
	ArrayList<VideoGame> videoGames = new ArrayList();

	public Loja() {

	}

	public Loja(String nome, String cnpj, ArrayList<Livro> livros, ArrayList<VideoGame> videoGames) {
		this.nome = nome;
		this.cnpj = cnpj;
		this.livros = livros;
		this.videoGames = videoGames;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getCnpj() {
		return cnpj;
	}

	public void setCnpj(String cnpj) {
		this.cnpj = cnpj;
	}

	public ArrayList<Livro> getLivros() {
		return livros;
	}

	public void setLivros(ArrayList<Livro> livros) {
		this.livros = livros;
	}

	public ArrayList<VideoGame> getVideoGames() {
		return videoGames;
	}

	public void setVideoGames(ArrayList<VideoGame> videoGames) {
		this.videoGames = videoGames;
	}

	public void listaLivros() {
		if (livros.size() > 0) {
			for (int i = 0; i < livros.size(); i++) {
				System.out.println("Titulo: " + livros.get(i).getNome() + ", preço: " + livros.get(i).getPreco()
						+ ", quantidade: " + livros.get(i).getQtd() + " em estoque.");
			}
		} else {
			System.out.println("A loja não tem livros no seu estoque.");
		}

	}

	public void listaVideoGames() {
		if (videoGames.size() > 0) {
			for (int i = 0; i < videoGames.size(); i++) {
				System.out.println("Video-game: " + videoGames.get(i).getModelo() + ", preço: " + videoGames.get(i).getPreco()
						+ ", quantidade: " + videoGames.get(i).getQtd() + " em estoque.");
			}

		} else {
			System.out.println("A loja não tem video-games no seu estoque.");
		}
	}

	public double calculaPatrimonio() {
		double x = 0;
		double y = 0;
		for (int i = 0; i < livros.size(); ++i) {
			x += livros.get(i).getPreco() * livros.get(i).getQtd();
		}
		for (int i = 0; i < videoGames.size(); ++i) {
			y += videoGames.get(i).getPreco() * videoGames.get(i).getQtd();
		}

		System.out.println("O patrimônio da loja: Americanas é de R$ " + (x + y));

		return x + y;
	}
}
