namespace bytebank_ADM.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer()
        {
        }

        public Designer(string nome, string cpf) : base(nome, cpf, 3000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
