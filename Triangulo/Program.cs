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
            int[] lados = new int[3];
            for (int i = 0; i < 3; i++)
			{
                lados[i] = int.Parse(Console.ReadLine());
			}
            Triangulo a = new Triangulo(lados[0], lados[1], lados[2]);
            Console.WriteLine("{0} {1} {2}", a.LadoA, a.LadoB, a.LadoC);
            
        }
    }
}
