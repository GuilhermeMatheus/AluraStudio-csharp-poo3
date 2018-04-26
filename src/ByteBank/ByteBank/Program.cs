using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario("434.568.190-20");

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            Console.WriteLine(carlos.Nome);
            Console.ReadLine();
        }
    }
}
