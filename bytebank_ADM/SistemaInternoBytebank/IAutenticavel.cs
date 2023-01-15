using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInternoBytebank
{
    public interface IAutenticavel
    {
        string Login { get; set; }
        string Senha { get; set; }

        bool Autenticar(string login, string senha);
 
    }
}
