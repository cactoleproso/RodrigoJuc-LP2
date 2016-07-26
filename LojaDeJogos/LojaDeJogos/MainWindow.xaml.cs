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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LojaDeJogos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void Bt_Add(object sender, RoutedEventArgs e)
        {
            
        }

        private void Bt_Con(object sender, RoutedEventArgs e)
        {
            Consultar con = new Consultar();
            con.Show();
            this.IsEnabled = false;
        }

        private void Bt_Alt(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_Rem(object sender, RoutedEventArgs e)
        {

        }
        private void NumAdd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
