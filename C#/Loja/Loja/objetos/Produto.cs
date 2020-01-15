using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadao.objetos
{
    abstract class Produto
    {
        protected String nome;
        protected double preco;
        protected int qtd;

        protected Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public String Nome { get { return this.nome; } set { this.nome = value; } }
        public double Preco { get { return this.preco; } set { this.preco = value; } }
        public int Qtd { get { return this.qtd; } set { this.qtd = value; } }

        public abstract void produto();

    }
}
