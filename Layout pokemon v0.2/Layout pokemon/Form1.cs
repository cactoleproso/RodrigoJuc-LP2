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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    
        }

        public void listarpkm()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            cmd.CommandText = "SELECT * FROM pokedex WHERE criador ='" + Login.UsuarioLogado + "'";
            MySqlDataReader ler;       
            try
            {
                cmd.Connection.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    string snome = ler.GetString("Nome");
                    listBox1.Items.Add(snome);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaPokemon criar = new ListaPokemon();
            criar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Batalha b = new Batalha();
            b.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Att_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listarpkm();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
