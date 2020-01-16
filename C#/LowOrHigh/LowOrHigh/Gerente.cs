using System;
using System.Collections.Generic;
using System.Text;

namespace LowOrHigh
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double bonificacao()
        {
            Salario = Salario + 10000.00;
            return Salario;
        }
    }
}
