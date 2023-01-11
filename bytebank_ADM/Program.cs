using bytebank_ADM.Funcionarios;
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
            Console.WriteLine(Pedro.Cpf);
            Console.WriteLine(Pedro.Salario);

            Console.ReadLine();
        }
    }
}
