using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadao.objetos
{
    class Livro : Produto
    {
        

        public Livro(string nome, double preco, int qtd, String autor, String tema, int qtdPag ) : base(nome, preco, qtd)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;
        }


        public String Autor { get; set; }
        public String Tema { get; set;  }
        public int QtdPag { get; set; }

        public double calculaImposto()
        {
            if (Tema == "educativo")
            {
                Console.WriteLine("Livro educativo não tem imposto: " + Nome);
                return 0;
            }
            else
            {
                double aux;
                aux = Preco * 0.10;
                Console.WriteLine("R$ " + aux + " de imposto sobre o livro " + Nome);
                return Preco;
            }
        }

        public override void produto()
        {
            
        }
    }
}
