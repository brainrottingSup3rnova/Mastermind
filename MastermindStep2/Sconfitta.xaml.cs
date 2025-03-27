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
using MastermindLibrary;
namespace MastermindStep2
{
    /// <summary>
    /// Logica di interazione per Sconfitta.xaml
    /// </summary>
    public partial class Sconfitta : Window
    {
        private MainWindow _main;
        private Giocatore _giocatore;
        public Sconfitta(Giocatore giocatoreCorrente,MainWindow mainWindow)
        {
            _giocatore = giocatoreCorrente;
            _main = mainWindow;
            InitializeComponent();
        }

        private void Button_Click_TornaHome(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            Close();
        }

        private void Button_Click_Esci(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
