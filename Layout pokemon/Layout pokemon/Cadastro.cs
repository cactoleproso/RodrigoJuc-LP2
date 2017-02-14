using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Layout_pokemon
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public void Cadastrar()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
            cmd.CommandText = "SELECT Id FROM login WHERE NomeUser= @caduser" ;
            cmd.Parameters.AddWithValue("@caduser", cadastroUsuario.Text);         
            cmd.Connection.Open();
            MySqlDataReader ler = cmd.ExecuteReader();
            if (ler.HasRows)
            {
                MessageBox.Show("Já existe um usuário com este nome.");
            }
            else
            {
                cmd.CommandText = "INSERT INTO login (NomeUser, Senha) VALUES (@nomeuser, @sen);";
                cmd.Parameters.AddWithValue("@nomeuser", cadastroUsuario.Text);
                cmd.Parameters.AddWithValue("@sen", cadastrosenha1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro feito com sucesso!");
                this.Close();
            }
            cmd.Connection.Close();
        }

        private void cadastrosenha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastreok_Click(object sender, EventArgs e)
        {

            if (cadastrosenha1.Text == cadastrosenha2.Text)
            {
                
                Cadastrar();               

            }
            else
            {
                MessageBox.Show("As senhas não conferem");
                cadastrosenha1.Text = string.Empty;
                cadastrosenha2.Text = string.Empty;
            }
                
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
