using MastermindLibrary;
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
        private Giocatore _giocatore;
        private MainWindow _main;
        public Regole(Giocatore giocatoreCorrente, MainWindow main)
        {
            _giocatore = giocatoreCorrente;
            InitializeComponent();
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            imgRegole.Source = new BitmapImage(new Uri(System.IO.Path.Combine(exePath, "../../../Immagini/imgRegole.png"), UriKind.Absolute));
            _main = main;
        }

        private void Button_Click_TornaIndietro(object sender, RoutedEventArgs e)
        {
            _main.Show();
            this.Close();
        }

    }
}