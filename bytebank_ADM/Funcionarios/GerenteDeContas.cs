using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas()
        {
        }

        public GerenteDeContas(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }

        public override double GetBonificacao()
        {
            return this.Salario;
        }
    }
}
