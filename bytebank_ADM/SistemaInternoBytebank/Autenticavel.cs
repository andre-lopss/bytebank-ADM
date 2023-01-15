using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInternoBytebank
{
    public abstract class Autenticavel : Funcionario
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public Autenticavel()
        {
        }

        public Autenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public bool Autenticar(string login, string senha)
        {
            return (Senha == senha && Login == login);
        }
    }
}
