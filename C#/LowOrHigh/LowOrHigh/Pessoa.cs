using System;

public class Pessoa
{
	private String nome;
	private int idade;

	public Pessoa() {
	}

	public Pessoa(String nome, int idade) {
		this.nome = nome;
		this.idade = idade;
	}

    public string Nome { get => nome; set => nome = value; }
    public int Idade { get => idade; set => idade = value; }


}
