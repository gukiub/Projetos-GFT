using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mercadao.objetos
{
	class Loja
	{
		

		public string Nome { get; set; }
		public string Cnpj { get; set; }
		internal List<Livro> Livros { get; set; }
		internal List<VideoGame> VideoGames { get; set; }

		public Loja(String nome, String cnpj, List<Livro> livros, List<VideoGame> videoGames)
		{
			this.Nome = nome;
			this.Cnpj = cnpj;
			this.Livros = livros;
			this.VideoGames = videoGames;
		}

		

		public void listaLivros()
		{
			
			if (Livros.Count > 0)
			{
				foreach (Livro livro in Livros)
				{
					Console.WriteLine("Titulo: {0}, preço: {1:0.00}, quantidade: {2}", livro.Nome, livro.Preco, livro.Qtd);
				}
			}
			else
			{
				Console.WriteLine("A loja não tem livros no seu estoque.");
			}

		}

		 public void listaVideoGames()
			{
				if (VideoGames.Count > 0)
				{
					foreach (VideoGame videoGame in VideoGames)
					{
						Console.WriteLine("Video-game: {0}, preço: {1}, quantidade: {2} em estoque.", videoGame.Modelo, videoGame.Preco, videoGame.Qtd);
					}

				}
				else
				{
					Console.WriteLine("A loja não tem video-games no seu estoque.");
				}
			}
			
					public double calculaPatrimonio()
					{
						double x = 0;
						double y = 0;
						foreach (Livro livro in Livros)
						{
				x += livro.Preco * livro.Qtd;
						}
						foreach (VideoGame videoGame in VideoGames)
						{
				y += videoGame.Preco * videoGame.Qtd;
						}

						Console.WriteLine("O patrimônio da loja: Americanas é de R$ " + (x + y));

						return x + y;
					}

				

		} 
}

