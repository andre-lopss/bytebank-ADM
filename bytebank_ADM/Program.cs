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
            #region
            //Diretor Marcio = new Diretor("Marcio Silva", "11122233345");
            //Console.WriteLine(Marcio.Nome);
            //Console.WriteLine(Marcio.GetBonificacao());

            //GerenteDeContas Carlos = new GerenteDeContas("Carlos Silva", "11122888345");
            //Console.WriteLine(Carlos.Nome);
            //Console.WriteLine(Carlos.GetBonificacao());

            //GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            //gerenciador.Registrar(Marcio);
            //gerenciador.Registrar(Carlos);
            //Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
            //Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
            #endregion

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            Designer ulisses = new Designer("Ulisses Souza", "0842484561");
            Diretor paula = new Diretor("Paula Souza", "42451546252");
            Auxiliar igor = new Auxiliar("Igor Dias", "88899966655");
            GerenteDeContas camila = new GerenteDeContas("Camila Lopes", "99988877744");

            gerenciador.Registrar(ulisses);
            gerenciador.Registrar(paula);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificação: " + gerenciador.TotalDeBonificacao);


            Console.ReadLine();
        }
    }
}
