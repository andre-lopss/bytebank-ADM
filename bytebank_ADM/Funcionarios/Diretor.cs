using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    { 
        public Diretor()
        {
        }

        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao() + this.Salario;
        }

        public override double PremioSemestral()
        {
            return base.PremioSemestral() + this.Salario;
        }
    }
}
