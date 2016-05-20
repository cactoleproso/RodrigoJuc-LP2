﻿using System;
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
            int aux = 0;
            int tent = 0;
            string palavra = Console.ReadLine();
            Console.Clear();
            char[] ast = new char[palavra.Length];
            for (int i = 0; i < palavra.Length; i++)           
                ast[i] = '*';        
            while ( true)
            {
                bool venceu = false;
                bool erro = true;
                Console.WriteLine("Tente uma letra");
                char letra = char.Parse(Console.ReadLine());
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (letra == palavra[i])
                    {
                        ast[i] = letra;
                        erro = false;
                    }
                    if ( ast[i] == palavra[i])
                        aux++;
                    if ( aux == palavra.Length)
                    {
                        venceu = true;
                        Console.WriteLine("Você venceu");
                        break;
                    }
                }
                if (venceu == true)
                    break;
                aux = 0;
                if ( erro == true)
                {
                    tent++;
                    Console.WriteLine("Você errou, você tem mais {0} tentativas", 7 - tent);
                }
                if (tent == 7)
                {
                    Console.WriteLine("Perdeu 3:");
                    break;
                }
                Console.WriteLine(ast);
            }
        }
    }
}
