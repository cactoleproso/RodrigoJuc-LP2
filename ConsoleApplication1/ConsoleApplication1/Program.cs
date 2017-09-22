using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) //falta adicionar o sair, também falta stopwatch e enum
        {
            Console.WriteLine("AGENDA");
            int count = 0; int dia =0; int hora = 0; int minutos = 0; string nomeEvento = "aa";
            while (count == 0)
            {
                Console.Clear();
                try
                {
                    Dictionary<string,DateTime> eventos = new Dictionary<string,DateTime>();
                    Console.WriteLine("1- Adicionar evento à agenda");
                    Console.WriteLine("2- Consultar evento");
                    Console.WriteLine("3- Confiar na sua memória e sair da querida agenda :'( ");
                    Console.WriteLine("Digite a opção desejada e aperte enter:");

                    int resposta = int.Parse(Console.ReadLine());

                    if (resposta == 1)
                    {
                        Console.WriteLine("Digite o nome do evento");
                        nomeEvento = Console.ReadLine();
                        Console.WriteLine("Digite o dia do evento");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite que horas será o evento ( primeiro horas e depois minutos )");
                        hora = int.Parse(Console.ReadLine());
                        minutos = int.Parse(Console.ReadLine());
                        
                    }
                        
                    else if (resposta == 2)
                    {
                        DateTime evento = new DateTime(2017, 9, dia, hora, minutos, 00);
                        eventos.Add(nomeEvento, evento);
                        foreach(KeyValuePair<string, DateTime> nome in eventos)
                        {
                            Console.WriteLine(nome.Key);
                            Console.WriteLine(nome.Value);
                        }
                        Console.ReadLine();
                    }

                    else if (resposta == 3)
                    {
                        count = 1;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("Po digita namoral ae >:( ");
                }
            }       
            }
            
        }
    }
