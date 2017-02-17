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
    public partial class Login : Form
    {
        private bool Logado = false;
        public Login()
        {
            InitializeComponent();
        }
        bool FazerLogin()
        {
            bool result = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            try
            {
                cmd.CommandText = "SELECT * FROM login WHERE NomeUser = '" + UsuarioTxt.Text + "' AND senha = '" + SenhaTxt.Text + "';";
                cmd.Connection.Open();
                MySqlDataReader dados = cmd.ExecuteReader();
                result = dados.HasRows;
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return result;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cadastre_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            bool result = FazerLogin();
            Logado = result;
            if (result)
            {
                MessageBox.Show("Bem vindo!");

            }
            else
            {
                MessageBox.Show("usuario/senha incorreto");
            }
        }




    }
}