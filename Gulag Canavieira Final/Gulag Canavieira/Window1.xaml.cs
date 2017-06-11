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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gulag_Canavieira
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string listgulag { get; set; }

        public Window1(string listgulagitem)
        {
            InitializeComponent();
            this.listgulag = listgulagitem;
            
        }

        private void novomotivo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = new MySqlConnection("Server=localhost; Database=gulag; Uid=root; Pwd=root"),
                    CommandText = string.Format("UPDATE gulag SET Motivo = '{0}' WHERE Nome = '{1}'", NovoMotivotxt.Text, listgulag)
                };
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                this.Close();
            }
            catch
            {

            }
        }
    }
}
