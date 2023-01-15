using bytebank_ADM.SistemaInternoBytebank;

namespace bytebank_ADM.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return (Senha == senha && Login == login);
        }
    }
}
