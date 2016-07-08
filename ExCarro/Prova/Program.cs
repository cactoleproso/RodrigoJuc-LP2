using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Program
    {
        public static void Main(string[] args)
        {
            Corrida c = new Corrida();
            Console.WriteLine(" A corrida será feita num percurso de 1500 metros, digite quantos carros irão participar ");
            int ncarros = int.Parse(Console.ReadLine());
            for (int i = 0; i < ncarros; i++)
            {
                Carro a = new Carro();
                Console.WriteLine("Indique a velocidade máxima do {0}º carro em km/h" , i + 1);
                a.Velocidade = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Indique o modelo do {0}º carro", i + 1);
                a.Modelo = Console.ReadLine();
                Console.Clear();
                c.AddCarro(a);
            }
            Console.WriteLine(c.Vencedor());
            

        }
    }
}
