using System;

namespace bytebank_ADM.SistemaInternoBytebank
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema, " + funcionario.Nome+"!");
                return true;
            } else
                Console.WriteLine("Senha ou usuário incorreto");
                return false;
        }
    }
}
