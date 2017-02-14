using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {   
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Console.Write("Digite nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite Sobrenome: ");
            p.Sobrenome = Console.ReadLine();

            Cadastrar(p); 
        }
        static void Cadastrar(Pessoa pessoa)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            MySqlCommand cmd = new MySqlCommand();
            
            cmd.Connection = conn;
            //    OU
            //   MySqlCommand cmd = new MySqlCommand()
            //  {
            //       Connection = new MySqlConnection("Server=...."),
            //       CommandText = "INSERT INTO aula (nome, sobrenome) VALUES (@nome, @sobrenome);"
            //
            //
            //
            //
            cmd.CommandText = "INSERT INTO aula (Nome, Sobrenome) VALUES (@nome, @sobrenome);";

            cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", pessoa.Sobrenome);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


            //cadastra dados
        }
    }
}
