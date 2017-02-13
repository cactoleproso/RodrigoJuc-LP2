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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void cadastrosenha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastreok_Click(object sender, EventArgs e)
        {
            if (cadastrosenha1 == cadastrosenha2)
            {

            }
            else
                senhainc.Text = "As senhas não conferem";
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
