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
        public enum ItemMenu { Adicionar, Consultar }
        static void Main(string[] args) 
        {
            Console.WriteLine("BEM VINDO A AGENDA DE OUTUBRO :^) ");
            int count = 0; int dia =0; int hora = 0; int minutos = 0; string nomeEvento = "aa";
            Stopwatch tempo = new Stopwatch(); // tempo que o programa está rodando
            tempo.Start();
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
                        ItemMenu selecionado = ItemMenu.Adicionar; 
                        Console.Clear();
                        if (selecionado == ItemMenu.Adicionar)
                        {
                            Console.WriteLine("opção selecionada: {0}", (int)selecionado);        //funcionamento do Enum
                        }
                        Console.WriteLine(selecionado);
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
                        ItemMenu selecionado = ItemMenu.Consultar; 
                        Console.Clear();
                        Console.WriteLine(selecionado);
                        DateTime evento = new DateTime(2017, 10, dia, hora, minutos, 00);
                        eventos.Add(nomeEvento, evento);
                        foreach(KeyValuePair<string, DateTime> nome in eventos)
                        {
                            Console.WriteLine(nome.Key);
                            Console.WriteLine(nome.Value);
                        }
                        if(selecionado == ItemMenu.Consultar)
                        {
                            Console.WriteLine("opção selecionada: {0}", (int)selecionado);
                        }
                        Console.ReadLine();
                    }

                    else if (resposta == 3)
                    {
                        
                        tempo.Stop();
                        TimeSpan ts = tempo.Elapsed;
                        Console.WriteLine("Você passou {0} horas, {1} minutos e {2} segundos na agenda!", ts.Hours, ts.Minutes, ts.Seconds);
                        Console.ReadLine();
                        count = 1;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Po digita namoral ae >:( ");
                    Console.ReadLine();                 
                }
                catch (Exception)
                {
                    Console.WriteLine("Não há eventos marcados");
                    Console.ReadLine();
                }
            }       
            }
            
        }
    }
