using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = Console.ReadLine();
            Console.Clear();
            char[] ast = new char[palavra.Length];
            for (int i = 0; i < palavra.Length; i++)
            {
                ast[i] = '*';
            }
            int tent = 0;
            bool erro = true;
            while ( true)
            {
                Console.WriteLine("Tente uma letra");
                char letra = char.Parse(Console.ReadLine());
                for (int i = 0; i < palavra.Length; i++)
                {
                    if ( letra == palavra[i])
                    {
                        for (int j = i; j < palavra.Length; j++)
                        {
                            if (letra == palavra[j])
                            {
                                erro = false;
                                ast[j] = letra;
                            }
                        }

                    }
                    if ( erro == true)
                    {                        
                            tent++;
                            Console.WriteLine("ERROU! você tem mais {0} tentativas", 7 - tent);
                            if (tent == 7)
                            {
                                Console.WriteLine("Perdeu 3: ");
                                break;

                            }
                            break;                 
                    }

                    

                    
                }
                if (tent == 7)
                    break;
                string ast1 = new string(ast);
                Console.WriteLine(ast1);
            }
        }
    }
}
