using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MastermindLibrary;
using System.Windows.Controls; // Add this import
using MastermindLibrary;
namespace MastermindStep2
{
    /// <summary>
    /// Logica di interazione per Gioco.xaml
    /// </summary>
    public partial class GiocoWPF : Window
    {
        private MainWindow _main;
        private Giocatore _giocatore;
        private Gioco _partita;
        private ColoriDellaSequenza[] _risultatoSequenza = new ColoriDellaSequenza[4];
        private ColoriDellaSequenza[] _sequenzaFullNera = new ColoriDellaSequenza[4]
        {
            ColoriDellaSequenza.NERO,
            ColoriDellaSequenza.NERO,
            ColoriDellaSequenza.NERO,
            ColoriDellaSequenza.NERO
        };

        public GiocoWPF(Giocatore giocatoreCorrente, MainWindow mainWindow)
        {
            _main= mainWindow;
            _giocatore = giocatoreCorrente;
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

        // Replace the GetColor method with the following
        private System.Windows.Media.Color GetColor(ColoriDellaSequenza colors)
        {
            switch (colors)
            {
                case ColoriDellaSequenza.VERDE:
                    return System.Windows.Media.Colors.Green;
                case ColoriDellaSequenza.ROSSO:
                    return System.Windows.Media.Colors.Red;
                case ColoriDellaSequenza.BLU:
                    return System.Windows.Media.Colors.Blue;
                case ColoriDellaSequenza.GIALLO:
                    return System.Windows.Media.Colors.Yellow;
                case ColoriDellaSequenza.ARANCIONE:
                    return System.Windows.Media.Colors.Orange;
                default:
                    return System.Windows.Media.Colors.White;
            }
        }
        private void BtnControlla_Controlla(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button button = (System.Windows.Controls.Button)sender;
            button.Visibility=Visibility.Hidden;
            _risultatoSequenza = _partita.ControllaTentativo(sequenzaInviata);
            if(_risultatoSequenza == _sequenzaFullNera)
            {
                Vittoria();
            }
            else if (_partita.TentativiRimanenti<=0)
            {
                Sconfitta();
            }
        }

        private ColoriDellaSequenza[] sequenzaInviata = new ColoriDellaSequenza[4];

        private void btn_addSequence(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button btn = sender as System.Windows.Controls.Button;
            int buttonNumber;
            var grid = btn.Template.FindName("buttonGrid", btn) as Grid;
            if (grid != null)
            {
                var ellipse = grid.Children[0] as Ellipse;
                if (ellipse != null)
                {
                    // Cambia il colore di riempimento dell'ellisse
                    ellipse.Fill = new SolidColorBrush(GetColor(_ultimoColoreCliccato));
                }
            }
            if (int.TryParse(btn.Name.Replace("btn_", ""), out buttonNumber))
            {
                int index = (buttonNumber - 1) % 4;
                sequenzaInviata[index] = _ultimoColoreCliccato;
            }
        }

        private void Vittoria()
        {
           Vittoria vittoria = new Vittoria(_giocatore, _main);
           this.Close();
           vittoria.ShowDialog();
        }

        private void Sconfitta()
        {
            Sconfitta sconfitta = new Sconfitta(_giocatore, _main);
            this.Close();
            sconfitta.ShowDialog();
        }
    }
}
