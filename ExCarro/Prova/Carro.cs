using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenhoProvaAmanhã
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            p.Sobrenome = Console.ReadLine();
            Cadastrar(p);

            foreach (Pessoa P in Consulta())
            {
                Console.WriteLine(" Id = {0}\n Nome = {1}\n Sobrenome = {2}", p.Id, p.Nome, p.Sobrenome);
            }

        }

        static void Cadastrar(Pessoa p)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=turma;Uid=root;Pwd="),
                CommandText = "INSERT INTO Pessoa (Nome, Sobrenome) VALUES (@nome, @sobrenome);"
            };

            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", p.Sobrenome);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<Pessoa> Consulta()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=turma;Uid=root;Pwd="),
                CommandText = "SELECT * FROM Pessoa"
            };

            cmd.Connection.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Id = result.GetInt32(0);
                    p.Nome = result.GetString(1);
                    p.Sobrenome = result.GetString(2);
                    pessoas.Add(p);
                }
            }
            cmd.Connection.Close();
            return pessoas;
        }
    }
}
