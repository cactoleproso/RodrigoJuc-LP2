using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula de get/set
            ContaCorrente c = new ContaCorrente();
            c.NomeCliente = "Jooj";
            c.Saldo = 5000;
            c.Debitar(500);
            if (c.Saldo >= 500)
            {
                Console.WriteLine(c.Saldo);
            }
            
        }
    }
}
