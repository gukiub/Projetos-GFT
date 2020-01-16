using System;
using System.Collections.Generic;
using System.Text;

namespace LowOrHigh
{
    abstract class Funcionario
    {
        private String nome;
        private int idade;
        private double salario;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Salario { get => salario; set => salario = value; }

        public Funcionario(string nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }

        public abstract double bonificacao();

    }
}
