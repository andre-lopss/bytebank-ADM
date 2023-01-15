namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
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
