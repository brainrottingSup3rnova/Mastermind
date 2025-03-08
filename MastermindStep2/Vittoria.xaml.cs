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

namespace MastermindStep2
{
    /// <summary>
    /// Logica di interazione per Vittoria.xaml
    /// </summary>
    public partial class Vittoria : Window
    {
        public Vittoria()
        {
            InitializeComponent();
        }

        private void Button_Click_Esci(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_TornaHome(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            Close();
        }
    }
}
