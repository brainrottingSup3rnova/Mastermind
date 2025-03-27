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
    /// Logica di interazione per Profilo.xaml
    /// </summary>
    public partial class Profilo : Window
    {
        public Profilo()
        {
            InitializeComponent();
        }

        private void btnTornaAllaHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {

            txtbox_Nome.Text = ""; // Cancella il testo presente nella TextBox
        }
    }
}
