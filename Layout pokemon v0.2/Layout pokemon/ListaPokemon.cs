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
    public partial class ListaPokemon : Form
    {
        public ListaPokemon()
        {
            InitializeComponent();
        }
        public void CadastrarPkm()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            cmd.CommandText = "SELECT Id FROM pokedex WHERE Nome= @nomepkm";
            cmd.Parameters.AddWithValue("@nomepkm", nomeL.Text);
            cmd.Connection.Open();
            MySqlDataReader ler = cmd.ExecuteReader();
            if (ler.HasRows)
            {
                MessageBox.Show("Já existe um pokemon com este nome.");
                cmd.Connection.Close();
            }
            else
            {
                cmd.CommandText = "INSERT INTO pokedex (Criador, Nome, Tipo, ATK, DEF, HP) VALUES (@cria, @nome, @tipo, @atk, @def, @hp);";
                cmd.Parameters.AddWithValue("@cria", Login.UsuarioLogado);
                cmd.Parameters.AddWithValue("@nome", nomeL.Text);
                cmd.Parameters.AddWithValue("@tipo", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@atk", ataqueL.Text);
                cmd.Parameters.AddWithValue("@def", defesaL.Text);
                cmd.Parameters.AddWithValue("@hp", hpL.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro feito com sucesso!");
                this.Close();
                cmd.Connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int atk = int.Parse(ataqueL.Text);
            int def = int.Parse(defesaL.Text);
            int hp = int.Parse(hpL.Text);
            if (hp != 0 && def != 0 && atk != 0)
            {
                if (hp + def + atk == 180)
                {
                    CadastrarPkm();

                }
                else
                    MessageBox.Show("A soma do ataque + defesa + hp deve ser igual a 180");
            }
            else
                MessageBox.Show("Os valores não podem ser '0'");
            
        }

        private void ataqueL_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
