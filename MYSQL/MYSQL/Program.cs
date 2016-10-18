using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MYSQL
{ //botão direito no mysql > get nuget packets > procurar online por MySql
    class Program
    {
        static void Main(string[] args)
        {
            //configuração
            string connStr = "Server=localhost; Database=Aula;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connStr);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM CARRO c WHERE c.IdCidade = (SELECT cid.Id FROM CIDADE cid WHERE cid.Nome = 'Rio de Janeiro');"; //tabela com id da cidade
            //precisa de uma class carro ^^^

            //execução
            cmd.Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();  //tipo de retorno STRING
           // cmd.ExecuteScalar(); --> retorna numero  ( Select SUM(p.preco) from PRODUTO )                       
            // ^^ double preçototal = Convert.ToDouble(cmd.ExecuteScalar);
            List<Carro> carros = new List<Carro>();
            if(reader.HasRows) // se ele não achar nada na lista, ele crasha, isso impede
            {
                while (reader.Read() == true)
                {
                    //criar istancia para cada item da lista, para adicionar na classe CARRO
                    Carro c = new Carro();
                    c.id = reader.GetInt32(0);
                    c.Placa = reader.GetString(1);
                    c.IdCidade = reader.GetInt32(2);
                    c.PreçoRevenda = reader.GetDouble(3);

                    carros.Add(c);
                }
            }         
            //int result = cmd.ExecuteNonQuery();  --> usado para modificar o BD, retorna o número de linhas alteradas (update/delete/insert)  
            reader.Read(); // RETORNA BOOL usado para botar num while  // toda vez que usamos read, ele vê para o próximo da tabela  read--> |  1
//                                                                                 2º read--->    |  2
//                                                                                                |  3
//                                                                                                |  4
            string nome = reader.GetString(0);
            Console.WriteLine("Nome: {0}", nome);
            cmd.Connection.Close();
        }
    }
}
