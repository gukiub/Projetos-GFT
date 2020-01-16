using System;
using System.Collections.Generic;
using System.Text;

namespace LowOrHigh
{
    class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double bonificacao()
        {
            Salario = Salario + 5000.00;
            return Salario;
        }
    }
}
