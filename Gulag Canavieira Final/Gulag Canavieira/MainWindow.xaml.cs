<<<<<<< HEAD
﻿using System;
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
            AtualizarListas();
        }


        public void AtualizarListas()
        {
            listgulag.Items.Clear();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost; Database=gulag; Uid=root; Pwd=root;"),
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
        // atualizar motivo na textbox
        public void AtualizarMotivo(string nome)
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost; Database=gulag; Uid=root; Pwd=root"),
                CommandText = string.Format("SELECT Motivo FROM gulag WHERE Nome = '{0}'", nome)
            };

            MySqlDataReader ler;
            try
            {
                cmd.Connection.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    string smotivo = ler.GetString("Motivo");
                    motivobox.Text = smotivo;
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
            cmd.Connection.Close();
        }

        public void MandarGulag()
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost; Database=gulag; Uid=root; Pwd=root"),
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
            if (string.IsNullOrWhiteSpace(Nometxt.Text) || string.IsNullOrWhiteSpace(MotivoTxt.Text))
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
            else
            {
                MandarGulag();
                AtualizarListas();
            }
        }

        private void listgulag_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Recuperar a info dequal item
            try
            {
                AtualizarMotivo(listgulag.SelectedItem.ToString());
            }
            catch
            {

            }
            
           

        }

        private void TirarGulag_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Você quer mesmo libertar esta pessoa do gulag?", "Libertar do gulag", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = new MySqlConnection("Server=localhost; Database=gulag; Uid=root; Pwd=root"),
                    CommandText = string.Format("DELETE FROM gulag WHERE Nome = '{0}'", listgulag.SelectedItem.ToString())
                };
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                AtualizarListas();
            } 
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            Window1 dialogo = new Window1(listgulag.SelectedItem.ToString());
            dialogo.Show();
            motivobox.Clear();
        }
    }
}
=======
﻿using System;
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
            AtualizarListas();
        }


        public void AtualizarListas()
        {
            listgulag.Items.Clear();
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

        public void AtualizarMotivo()
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost; Database=gulag; Uid=root; Pwd="),
                CommandText = "SELECT Motivo FROM gulag"
            };
            MySqlDataReader ler;
            try
            {
                cmd.Connection.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    string smotivo = ler.GetString("Motivo");
                    motivobox.Text = smotivo;
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
            cmd.Connection.Close();
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
            if (string.IsNullOrWhiteSpace(Nometxt.Text) || string.IsNullOrWhiteSpace(MotivoTxt.Text))
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
            else
            {
                MandarGulag();
                AtualizarListas();
            }
        }

        private void listgulag_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AtualizarMotivo();
        }
    }
}
>>>>>>> 921b6621fa320835635be74087afe9606879bfea
