using System;
using System.Collections.Generic;
using System.Text;

namespace LowOrHigh
{
    class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double bonificacao()
        {
            Salario = Salario + 3000.00;
            return Salario;
        }
    }
}
