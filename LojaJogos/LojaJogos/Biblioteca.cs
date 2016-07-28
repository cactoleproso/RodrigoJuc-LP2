using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJogos
{
    class Biblioteca
    {
        private List<Jogo> Jogos;
        public int IDcons { get; set;}
        public Biblioteca()
        {
            this.Jogos = new List<Jogo>();
        }
        public void AdicionarJogo(Jogo jogo)
        {
            this.Jogos.Add(jogo);
        }
        public void Consultar(int IDcons)
        {
            int count = 0;
            foreach( Jogo a in Jogos)
            {
                if (a.Id == IDcons)
                {
                    Console.Clear();
                    Console.WriteLine("Dados do jogo:");
                    Console.WriteLine("Nome: {0}", a.NomeJogo);
                    Console.WriteLine("Genero: {0}", a.Genero);
                    Console.WriteLine("ID: {0}", a.Id);
                    Console.WriteLine("Ano Lançado: {0}", a.Data);
                    Console.WriteLine("Desenvolvedor: {0}", a.Desenvolvedor);
                    Console.WriteLine("Requisitos: {0}", a.Requesitos);
                    Console.WriteLine("Preço: {0}", a.Preço);
                    break;
                }
                else
                    count++;
            }
            if ( count == Jogos.Count)
            {
                Console.WriteLine("Não foi encontrado nenhum jogo com esta ID.");
                
            }
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadLine();

        }
        public void Consultar(string nome )
        {
            int count = 0;
            foreach (Jogo a in Jogos)
            {
                if (a.NomeJogo == nome)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Dados do jogo:");
                    Console.WriteLine("Nome: {0}", a.NomeJogo);
                    Console.WriteLine("Genero: {0}", a.Genero);
                    Console.WriteLine("ID: {0}", a.Id);
                    Console.WriteLine("Ano Lançado: {0}", a.Data);
                    Console.WriteLine("Desenvolvedor: {0}", a.Desenvolvedor);
                    Console.WriteLine("Requisitos: {0}", a.Requesitos);
                    Console.WriteLine("Preço: {0}", a.Preço);
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------");
                }
                else
                    count++;
            }
            if (count == Jogos.Count)
            {
                Console.WriteLine("Não foi encontrado nenhum jogo com este nome ( cheque o seu caps lock ).");

            }
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadLine();

        }
        public void Consultar(double preço)
        {
            int count = 0;
            foreach (Jogo a in Jogos)
            {
                if (a.Preço <= preço)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Dados do jogo:");
                    Console.WriteLine("Nome: {0}", a.NomeJogo);
                    Console.WriteLine("Genero: {0}", a.Genero);
                    Console.WriteLine("ID: {0}", a.Id);
                    Console.WriteLine("Ano Lançado: {0}", a.Data);
                    Console.WriteLine("Desenvolvedor: {0}", a.Desenvolvedor);
                    Console.WriteLine("Requisitos: {0}", a.Requesitos);
                    Console.WriteLine("Preço: {0}", a.Preço);
                    Console.WriteLine("-------------------------");
                }
                else
                    count++;
            }
            if (count == Jogos.Count)
            {
                Console.WriteLine("Não foi encontrado nenhum jogo nesta faixa de preço.");

            }
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadLine();

        }
        public void Alterar(int IDcons)
        {          
            int count = 0;
            for (int i = 0; i < Jogos.Count; i++)
            {
                if (Jogos[i].Id == IDcons)
                {
                    Console.WriteLine("----------------Dados Antigos do jogo----------------");
                    Console.WriteLine("Nome: {0}", Jogos[i].NomeJogo);
                    Console.WriteLine("Genero: {0}", Jogos[i].Genero);
                    Console.WriteLine("ID: {0}", Jogos[i].Id);
                    Console.WriteLine("Ano Lançado: {0}", Jogos[i].Data);
                    Console.WriteLine("Desenvolvedor: {0}", Jogos[i].Desenvolvedor);
                    Console.WriteLine("Requisitos: {0}", Jogos[i].Requesitos);
                    Console.WriteLine("Preço: {0}", Jogos[i].Preço);
                    Console.WriteLine("----------------Dados Antigos do jogo----------------");
                    Jogos.RemoveAt(i);
                    count = -1;
                    break;
                }
                else
                    count++;
            }
            if (count == Jogos.Count)
            {
                Console.WriteLine("Não foi encontrado nenhum jogo com esta ID.");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadLine();
            }
            
        }
        public void Remover(int IDcons )
        {
            int count = 0;
            for (int i = 0; i < Jogos.Count; i++)
			{
                if (Jogos[i].Id == IDcons)
                {
                    Jogos.RemoveAt(i);
                    count = -1;
                    break;
                }
                else
                    count++;
			}

            if (count == Jogos.Count)
            {
                Console.WriteLine("Não foi encontrado nenhum jogo com esta ID.");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadLine();
            }
        }
    }
}
                      