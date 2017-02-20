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
using System.Threading;

namespace Layout_pokemon
{
    public partial class Login : Form
    {
        Thread lg;
        public static string UsuarioLogado;
        private bool Logado = false;
        public Login()
        {
            InitializeComponent();
        }
        bool FazerLogin()
        {
            bool result = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
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
            UsuarioLogado = UsuarioTxt.Text;
            bool result = FazerLogin();
            Logado = result;
            if (result)
            {
                MessageBox.Show("Bem vindo!");         
                this.Close();
                lg = new Thread(abrirnovaform);
                lg.SetApartmentState(ApartmentState.STA);
                lg.Start();
                
                
            }
            else
            {
                MessageBox.Show("usuario/senha incorreto");
            }
        }

        private void abrirnovaform(object obj)
        {
            Application.Run(new Form1());
        }
    }
}