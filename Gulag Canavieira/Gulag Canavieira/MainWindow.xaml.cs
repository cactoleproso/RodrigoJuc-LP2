using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gulag_Canavieira
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public void AtualizarLista()
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost; Database=gulag; Uid=root; Pwd="),
                CommandText = "SELECT nome FROM gulag"
            };

            MySqlDataReader ler;

            try
            {
                cmd.Connection.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    string snome = ler.GetString("Nome");
                    listgulag.Items.Add(snome);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }


        }


        public void MandarGulag()
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost; Database=gulag; Uid=root; Pwd="),
                CommandText = "SELECT id FROM gulag WHERE Nome= @Nome"
            };
            
            cmd.Parameters.AddWithValue("@Nome" ,Nometxt.Text);
            cmd.Connection.Open();

            if (cmd.ExecuteReader().HasRows)
            {
                MessageBox.Show("kkkkk esse daí já foi filhote");
                cmd.Connection.Close();
            }
            else
            {
                cmd.Connection.Close();
                cmd.Connection.Open();
                cmd.CommandText = "INSERT INTO gulag (Nome, Motivo) VALUES (@Nome1, @Motivo);";
                cmd.Parameters.AddWithValue("@Nome1", Nometxt.Text);
                cmd.Parameters.AddWithValue("@Motivo", MotivoTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("этот ублюдок будет про ГУЛАГ!");
            }
            cmd.Connection.Close();

        }

        private void mandargulag_Click(object sender, RoutedEventArgs e)
        {
            MandarGulag();
            AtualizarLista();
        }

        private void listgulag_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
