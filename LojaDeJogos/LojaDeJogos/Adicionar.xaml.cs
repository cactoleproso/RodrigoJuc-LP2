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
using System.Windows.Shapes;

namespace LojaDeJogos
{
    /// <summary>
    /// Interaction logic for Adicionar.xaml
    /// </summary>
    public partial class Adicionar : Window
    {
        MainWindow mw = new MainWindow();
        public Adicionar()
        {
            InitializeComponent();
            
        }
        public void AdicionarID_Click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(mw.NumAdd.Text);
            Jogo jogo = new Jogo();
            for (int i = 0; i < num; i++)
            {
                
            }
        }

        private void PreçoAD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AnoAD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ReqAD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GeneroAD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NomeAD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
