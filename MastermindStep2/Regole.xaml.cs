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
    /// Logica di interazione per Regole.xaml
    /// </summary>
    public partial class Regole : Window
    {
        public Regole()
        {
            InitializeComponent();
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            imgRegole.Source = new BitmapImage(new Uri(System.IO.Path.Combine(exePath, "../../../Immagini/imgRegole.png"), UriKind.Absolute));
        }

        private void Button_Click_TornaIndietro(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow home = new MainWindow();
            home.Show();
        }

    }
}