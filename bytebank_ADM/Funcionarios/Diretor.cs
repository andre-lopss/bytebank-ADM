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

        public Diretor(string nome, string cpf) : base(nome, cpf, 5000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.50;
        }

        public override double PremioSemestral()
        {
            return base.PremioSemestral() + this.Salario;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
