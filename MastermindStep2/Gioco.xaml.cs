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
    /// Logica di interazione per Gioco.xaml
    /// </summary>
    public partial class Gioco : Window
    {
        private Giocatore _giocatore;
        private Gioco _partita;
        private Bot _computer;
        public Gioco(Giocatore giocatoreCorrente)
        {
            _giocatore = giocatoreCorrente;
            _computer = new Bot();
            _partita = new Gioco(_giocatore);
            InitializeComponent();
        }

        private ColoriDellaSequenza _ultimoColoreCliccato;

        private void btnEsciGioco_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void BtnRosso_Click(object sender, RoutedEventArgs e)
        {
            _ultimoColoreCliccato = ColoriDellaSequenza.ROSSO;
        }

        private void BtnVerde_Click(object sender, RoutedEventArgs e)
        {
            _ultimoColoreCliccato = ColoriDellaSequenza.VERDE;
        }

        private void BtnBlu_Click(object sender, RoutedEventArgs e)
        {
            _ultimoColoreCliccato = ColoriDellaSequenza.BLU;
        }

        private void BtnGiallo_Click(object sender, RoutedEventArgs e)
        {
            _ultimoColoreCliccato = ColoriDellaSequenza.GIALLO;
        }

        private void BtnArancione_Click(object sender, RoutedEventArgs e)
        {
            _ultimoColoreCliccato = ColoriDellaSequenza.ARANCIONE;
        }

        private void BtnControlla_Controlla(object sender, RoutedEventArgs e)
        {
            ColoriDellaSequenza[] sequenzaInviata = new ColoriDellaSequenza[4];
            sequenzaInviata[0] = Grid.GetRow(_partita.TentativiRimanenti);
        }
    }
}
