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
            Console.WriteLine("Indique o número de triângulos que deseja de entrada");
            int triangulos = int.Parse(Console.ReadLine());
            double maiorp = 0; double maiorid = 0; int j = 0;
            double[] perimetros = new double[triangulos];
            int[] lados = new int[3 * triangulos];
            int[] ids = new int[triangulos];
            int numlados = 3 * triangulos;
            Console.WriteLine("Indique respectivamente o tamanho dos lados dos triângulos");
            for (int i = 0; i < numlados; i++)
			{
                lados[i] = int.Parse(Console.ReadLine());
			}
            Console.WriteLine("Informe respectivamente o ID dos triângulos");
            for (int i = 0; i < triangulos; i++)
            {
                ids[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numlados; i+=3)
            { 
                Triangulo a = new Triangulo(lados[i], lados[i + 1], lados[i + 2]);
                perimetros[j] = a.Perimetro;
                
                if (perimetros[j] > maiorp)
                    {              
                        maiorp = perimetros[j];
                        maiorid = ids[j];
                    }
                j++;
            }
            Console.WriteLine("o maior perimetro é {0} e o id deste triângulo é {1}", maiorp, maiorid);
        }
    }
}
