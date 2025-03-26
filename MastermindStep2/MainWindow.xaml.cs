using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MastermindStep2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            imgPascal.Source = new BitmapImage(new Uri(System.IO.Path.Combine(exePath, "../../../Immagini/imgPascal.png"), UriKind.Absolute));
        }

        private void btnGiocaOra_Click(object sender, RoutedEventArgs e)
        {
            Gioco gioco = new Gioco();
            this.Close();
            gioco.ShowDialog();
        }

        private void btnRegole_Click(object sender, RoutedEventArgs e)
        {
            Regole regole = new Regole();
            this.Close();
            regole.ShowDialog();
        }

        private void btnEsci_Click(object sender, RoutedEventArgs e)
        {
            Uscita uscita = new Uscita();
            this.Close();
            uscita.ShowDialog();
        }
    }
}