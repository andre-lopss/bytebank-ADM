namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario()
        {
            TotalDeFuncionarios++;
        }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract double GetBonificacao();

        public virtual double PremioSemestral()
        {
            return this.Salario * 0.20;
        }

        public abstract void AumentarSalario(); 
    }
}
