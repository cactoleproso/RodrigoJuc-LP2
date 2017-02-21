using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_pokemon
{
    public partial class Batalha : Form
    {
        public Batalha()
        {
            InitializeComponent();
            preencherlista();
        }
        void preencherlista()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            cmd.CommandText = "SELECT * FROM pokedex;";
            MySqlDataReader ler;
            
            try
            {
                cmd.Connection.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    string snome = ler.GetString("Nome");
                    listBox.Items.Add(snome);
                    listBox2.Items.Add(snome);
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        private void Batalha_Load(object sender, EventArgs e)
        {

        }

        private void batalhar_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void batalhar_Click_1(object sender, EventArgs e)
        {
            int ATK1; int DEF1; int HP1; string tipo1; int ATK2; int DEF2; int HP2; string tipo2; string nome1; string nome2;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            cmd.CommandText = "SELECT * FROM pokedex WHERE Nome = '" + listBox.GetItemText(listBox.SelectedItem) + "';";
            MySqlDataReader ler;
            cmd.Connection.Open();
            ler = cmd.ExecuteReader();
            ler.Read();
            nome1 = ler.GetString("Nome");
            tipo1 = ler.GetString("Tipo");
            ATK1 = ler.GetInt32("ATK");
            DEF1 = ler.GetInt32("DEF");
            HP1 = ler.GetInt32("HP");
            cmd.Connection.Close();
            cmd.Connection.Open();
            cmd.CommandText = "SELECT * FROM pokedex WHERE Nome = '" + listBox2.GetItemText(listBox2.SelectedItem) + "';";
            ler = cmd.ExecuteReader();
            ler.Read();
            nome2 = ler.GetString("Nome");
            tipo2 = ler.GetString("Tipo");
            ATK2 = ler.GetInt32("ATK");
            DEF2 = ler.GetInt32("DEF");
            HP2 = ler.GetInt32("HP");

            tipo1.ToString();
            tipo2.ToString();

            double multiplicador1 = 1;
            double multiplicador2 = 1;

            #region feio

            if (tipo1 == "agua" && tipo2=="fogo")
            {
                multiplicador1 = 1.50;
                multiplicador2 = 0.50;
            }
            
            else if (tipo1 == "fogo" && tipo2 == "agua")
            {
                multiplicador1 = 0.50;
                multiplicador2 = 1.50;
            }
            else if (tipo1 == tipo2)
            {
                multiplicador1 = 0.5;
                multiplicador2 = 0.5;
            }
            else if(tipo1 == "agua" && tipo2 == "eletrico")
            {
                multiplicador1 = 1;
                multiplicador2 = 1.50;
            }
            else if (tipo1 == "eletrico" && tipo2 == "agua")
            {
                multiplicador1 = 1.50;
                multiplicador2 = 1;
            }
            else if(tipo1 == "agua" && tipo2 == "rocha")
            {
                multiplicador1 = 1.5;
                multiplicador2 = 0.5;
            }
            else if (tipo1 == "rocha" && tipo2 == "agua")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 1.5;
            }
            else if(tipo1 == "agua" && tipo2 == "planta")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 1.5;
            }
            else if (tipo1 == "planta" && tipo2 == "agua")
            {
                multiplicador2 = 0.5;
                multiplicador1 = 1.5;
            }
            else if(tipo1 == "agua" && tipo2 == "agua")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 0.5;
            }
            else if (tipo1 == "fogo" && tipo2 == "planta")
            {
                multiplicador1 = 1.5;
                multiplicador2 = 0.5;
            }
            else if (tipo1 == "planta" && tipo2 == "fogo")
            {
                multiplicador2 = 1.5;
                multiplicador1 = 0.5;
            }//feito

            else if (tipo1 == "fogo" && tipo2 == "rocha")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 1.5;
            }
            else if (tipo1 == "rocha" && tipo2 == "fogo")
            {
                multiplicador2 = 0.5;
                multiplicador1 = 1.5;
            }//feito

            else if (tipo1 == "fogo" && tipo2 == "gelo")
            {
                multiplicador1 = 1.5;
                multiplicador2 = 0.5;
            }
            else if (tipo1 == "gelo" && tipo2 == "fogo")
            {
                multiplicador2 = 1.5;
                multiplicador1 = 0.5;
            }//feito

            else if (tipo1 == "planta" && tipo2 == "veneno")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 1.5;
            }
            else if (tipo1 == "veneno" && tipo2 == "planta")
            {
                multiplicador2 = 0.5;
                multiplicador1 = 1.5;
            }//feito

            else if (tipo1 == "planta" && tipo2 == "rocha")
            {
                multiplicador1 = 1.5;
                multiplicador2 = 0.5;
            }
            else if (tipo1 == "rocha" && tipo2 == "planta")
            {
                multiplicador2 = 1.5;
                multiplicador1 = 0.5;
            }//feito

            else if (tipo1 == "planta" && tipo2 == "gelo")
            {
                multiplicador1 = 1;
                multiplicador2 = 1.5;
            }
            else if (tipo1 == "gelo" && tipo2 == "planta")
            {
                multiplicador2 = 1;
                multiplicador1 = 1.5;
            }//feito

            else if (tipo1 == "planta" && tipo2 == "voador")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 1.5;
            }
            else if (tipo1 == "voador" && tipo2 == "planta")
            {
                multiplicador2 = 0.5;
                multiplicador1 = 1.5;
            }//feito

            else if (tipo1 == "planta" && tipo2 == "eletrico")
            {
                multiplicador1 = 1;
                multiplicador2 = 0.5;
            }
            else if (tipo1 == "eletrico" && tipo2 == "planta")
            {
                multiplicador2 = 1;
                multiplicador1 = 0.5;
            }//feito

            else if (tipo1 == "veneno" && tipo2 == "rocha")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 1.5;
            }
            else if (tipo1 == "rocha" && tipo2 == "veneno")
            {
                multiplicador2 = 0.5;
                multiplicador1 = 1.5;
            }//feito

            else if (tipo1 == "veneno" && tipo2 == "fantasma")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 1.5;
            }
            else if (tipo1 == "fantasma" && tipo2 == "veneno")
            {
                multiplicador2 = 0.5;
                multiplicador1 = 1.5;
            }//feito

            else if (tipo1 == "rocha" && tipo2 == "gelo")
            {
                multiplicador1 = 1.5;
                multiplicador2 = 0.5;
            }
            else if (tipo1 == "gelo" && tipo2 == "rocha")
            {
                multiplicador2 = 1.5;
                multiplicador1 = 0.5;
            }//feito

            else if (tipo1 == "rocha" && tipo2 == "voador")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 1.5;
            }
            else if (tipo1 == "voador" && tipo2 == "rocha")
            {
                multiplicador2 = 0.5;
                multiplicador1 = 1.5;
            }//feito

            else if (tipo1 == "rocha" && tipo2 == "eletrico")
            {
                multiplicador1 = 1.5;
                multiplicador2 = 0;
            }
            else if (tipo1 == "eletrico" && tipo2 == "rocha")
            {
                multiplicador2 = 1.5;
                multiplicador1 = 0;
            }//feito

            else if (tipo1 == "gelo" && tipo2 == "voador")
            {
                multiplicador1 = 1.5;
                multiplicador2 = 0.5;
            }
            else if (tipo1 == "voador" && tipo2 == "gelo")
            {
                multiplicador2 = 1.5;
                multiplicador1 = 0.5;
            }//feito 

            else if (tipo1 == "voador" && tipo2 == "eletrico")
            {
                multiplicador1 = 0.5;
                multiplicador2 = 1.5;
            }
            else if (tipo1 == "eletrico" && tipo2 == "voador")
            {
                multiplicador2 = 0.5;
                multiplicador1 = 1.5;
            }

            #endregion

            int deftotal1 = HP1 + DEF1;
            int deftotal2 = HP2 + DEF2;

            double valor1;
            double valor2;
            valor1 = deftotal2 / (ATK1 * multiplicador1);
            valor2 = deftotal1 / (ATK2 * multiplicador2);
            label7.Text = "Valor1: " + Convert.ToString(valor1);
            label6.Text = "Valor2: " + Convert.ToString(valor2);

            if (valor1 > valor2)
            {
                pkm1.Text =  nome2 +" venceu!";
            }
            else if (valor1 < valor2)
            {
                pkm1.Text = nome1 + " venceu!";
            }
            else
                pkm1.Text = "Os dois pokemons desmaiaram!";



            // ex: tipo 1 = agua ; tipo 2 = fogo
            // valor1= DEFTOTAL2/(ATKTOTAL1 * multiplicador1)     // normal = 1x  superefetivo = 1.50 nada efetivo = 0.5

            // valor2 = DEFTOTAL1/(ATKTOTAL2 * multiplicador2)   // tipos possiveis = agua/fogo/planta/veneno/pedra/fantasma/gelo/voador/eletrico
            
            
            
        }

        private void pkm1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}