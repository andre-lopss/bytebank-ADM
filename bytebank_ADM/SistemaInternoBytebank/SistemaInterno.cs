using System;

namespace bytebank_ADM.SistemaInternoBytebank
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema!");
                return true;
            } else
                Console.WriteLine("Senha ou usuário incorreto");
                return false;
        }
    }
}
