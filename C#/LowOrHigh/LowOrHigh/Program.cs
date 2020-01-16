using System;
using System.Collections.Generic;

namespace LowOrHigh
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);
            pessoas.Add(p4);

            int aux = 0;
            String aux2 = "";

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Idade > aux)
                {
                   aux = pessoa.Idade;
                    aux2 = pessoa.Nome;
                }       
            }
            
            Console.WriteLine("Pessoa com maior idade: " + aux2);
            Console.WriteLine("tamanho da lista antes da exclusão das pessoas com menos de 18 anos: {0}", pessoas.Count);

            for(int i = 0; i < pessoas.Count; i++)
            {
                Pessoa pessoa = new Pessoa();
                if (pessoa.Idade < 18) {
                    pessoas.RemoveAt(i);
                }
            }
            Console.WriteLine("tamanho da lista depois da exclusão das pessoas com menos de 18 anos: {0}", pessoas.Count);


            foreach(Pessoa pessoa in pessoas) { 
                if (pessoa.Nome == "Jessica") {
                    Console.WriteLine("jessica existe");
                }
            }

            Gerente gerente = new Gerente("batata", 20, 20.00);
            Supervisor supervisor = new Supervisor("batatao", 25, 10.00);
            Vendedor vendedor = new Vendedor("lasagna", 30, 90.00);

            gerente.bonificacao();
            supervisor.bonificacao();
            vendedor.bonificacao();

            Console.WriteLine(gerente.Nome + " " + gerente.Salario);
            Console.WriteLine(supervisor.Nome + " " + supervisor.Salario);
            Console.WriteLine(vendedor.Nome + " " + vendedor.Salario);
        }
    }
}
