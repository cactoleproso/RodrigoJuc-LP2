using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca b = new Biblioteca();
            bool sair = false;
            int n; int p; int count = 0;
            while ( count == 0)
            {
                
                Console.Clear();
                Console.WriteLine("Selecione uma das operações digitando o numero ao seu lado.");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("3 - Alterar");
                Console.WriteLine("4 - Remover");
                Console.WriteLine("5 - Sair");
                p = int.Parse(Console.ReadLine());
                if (p == 5)
                {
                    sair = true;
                }
                else if (p == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Quantos jogos você deseja adicionar?");
                    n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Jogo a = new Jogo();
                        Console.Clear();
                        Console.WriteLine("Qual é o nome deste jogo?");
                        a.NomeJogo = Console.ReadLine();
                        Console.WriteLine("Qual é o gênero deste jogo? ( ação/aventura/RPG )");
                        a.Genero = Console.ReadLine();
                        Console.WriteLine("Qual é o ano de lançamento deste jogo? ( digite no formato de dia/mês/ano )");
                        a.Data = Console.ReadLine();
                        Console.WriteLine("Qual é o preço deste jogo?");
                        a.Preço = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual é o ID de seu jogo?");
                        a.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual é o desenvolvedor desse jogo? ( ou empresa desenvolvedora )");
                        a.Desenvolvedor = Console.ReadLine();
                        Console.WriteLine("Quais são os requisitos para este jogo? ( CPU | VGA | RAM | OS | Espaço Necessário )");
                        a.Requesitos = Console.ReadLine();
                        b.AdicionarJogo(a);
                    }
                }
                if (p == 2)
                {
                    int IDcons;
                    double pr;
                    string nm;
                    Console.Clear();
                    Console.WriteLine("Digite 1 para buscar o jogo por ID, 2 para buscar pelo seu Nome ou 3 para buscar por um preço menor ou igual. ( esta serve para achar os jogos mais baratos )");
                    int op = int.Parse(Console.ReadLine());
                    if( op == 1)
                    {
                        Console.WriteLine("Digite a ID do jogo que você busca:");
                        IDcons = int.Parse(Console.ReadLine());
                        b.Consultar(IDcons);
                    }
                    if ( op == 2)
                    {
                        Console.WriteLine("Digite o nome do jogo que você busca:");
                        nm = Console.ReadLine();
                        b.Consultar(nm);
                    }
                    if (op == 3)
                    {
                        Console.WriteLine("Digite o preço do(s) jogo(s) que você busca:");
                        pr = double.Parse(Console.ReadLine());
                        b.Consultar(pr);
                    }
                }
                if (p == 3)
                {
                    Jogo a = new Jogo();
                    int IDcons;
                    Console.Clear();
                    Console.WriteLine("Digite a ID do jogo que você deseja alterar:");
                    IDcons = int.Parse(Console.ReadLine());
                    b.Alterar(IDcons);
                    Console.WriteLine("Se você quiser manter o mesmo atributo anterior à alteração, precisa digitar o mesmo");
                    Console.WriteLine("Digite o novo nome deste jogo:");
                    a.NomeJogo = Console.ReadLine();
                    Console.WriteLine("Digite o novo gênero deste jogo:");
                    a.Genero = Console.ReadLine();
                    Console.WriteLine("Digite o novo ano de lançamento deste jogo:");              
                    a.Data = Console.ReadLine();                
                    Console.WriteLine("Digite o novo preço deste jogo:");
                    a.Preço = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o novo ID deste jogo:");
                    a.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o novo desenvolvedor deste jogo:");
                    a.Desenvolvedor = Console.ReadLine();
                    Console.WriteLine("Digite os novos requesitos deste jogo:");
                    a.Requesitos = Console.ReadLine();
                    b.AdicionarJogo(a);
                    
                
                }
                if (p == 4)
                {
                    int IDcons;
                    Console.Clear();
                    Console.WriteLine("Digite a ID do jogo que você deseja remover:");
                    IDcons = int.Parse(Console.ReadLine());
                    b.Remover(IDcons);
                    
                }
                if (sair == true)
                    count = 1;
            }
        }
    }
}
