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
        }

        private void Batalha_Load(object sender, EventArgs e)
        {

        }

        private void batalhar_Click(object sender, EventArgs e)
        {
            string vence; 
            // ex: tipo 1 = agua ; tipo 2 = fogo
            // valor1= DEFTOTAL2/(ATKTOTAL1 * multiplicador1)     // normal = 1x  superefetivo = 1.50 nada efetivo = 0.5
                                           
            // valor2 = DEFTOTAL1/(ATKTOTAL2 * multiplicador2)   // tipos possiveis = agua/fogo/planta/veneno/pedra/fantasma/gelo/voador/eletrico
            double deftotal1;
            double deftotal2;
            double multiplicador1;
            double multiplicador2;
            if(//tipo1 == agua && tipo2==fogo)
            {
                multiplicador1 = 1.50;
                multiplicador2 = 0.50;
            }
            else if(//tipo1 == ....)
            {

            }

        }
    }
}
