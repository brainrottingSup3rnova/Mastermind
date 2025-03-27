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
    /// Logica di interazione per Profilo.xaml
    /// </summary>
    public partial class Profilo : Window
    {
        private Giocatore _giocatore;
        private MainWindow _main;
        public Profilo(Giocatore giocatoreCorrente,MainWindow main)
        {
            _giocatore = giocatoreCorrente;
            InitializeComponent();
            txtbox_Nome.Text = _giocatore.Nome;
            _main = main;
        }

        private void btnTornaAllaHome_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            _main.Show();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            txtbox_Nome.Text = string.Empty;
        }

        private void BtnSalva_Click(object sender, RoutedEventArgs e)
        {
            _giocatore.Nome = txtbox_Nome.Text;
        }
    }
}
