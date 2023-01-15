using bytebank_ADM.SistemaInternoBytebank;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Autenticavel
    {
        public GerenteDeContas()
        {
        }

        public GerenteDeContas(string nome, string cpf) : base(nome, cpf, 4000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
