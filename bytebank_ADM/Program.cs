using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Pedro = new Funcionario("Pedro Silva", "08342484507", 2000);
            Console.WriteLine(Pedro.Nome);
            Console.WriteLine(Pedro.GetBonificacao());

            Diretor Marcio = new Diretor("Marcio Silva", "11122233345", 10000);
            Console.WriteLine(Marcio.Nome);
            Console.WriteLine(Marcio.GetBonificacao());

            GerenteDeContas Carlos = new GerenteDeContas("Carlos Silva", "11122888345", 1000);
            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBonificacao());

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            gerenciador.Registrar(Pedro);
            gerenciador.Registrar(Marcio);
            gerenciador.Registrar(Carlos);
            Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
            Console.ReadLine();
        }
    }
}
