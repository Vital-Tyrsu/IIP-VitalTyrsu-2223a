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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfWinkel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //globale variabelen die vanaf het begin worden gedeclareerd.
        int aantalBananen;
        int aantalEieren;
        int aantalBoter;

        double totaal;

        const double PRIJS_BANAAN = 2.20;
        const double PRIJS_BOTER = 3.05;
        const double PRIJS_EIEREN = 2.75;


        public MainWindow()
        {
            InitializeComponent();

            Random rnd = new Random();
            aantalBananen = rnd.Next(5, 40);
            aantalEieren = rnd.Next(5, 40);
            aantalBoter = rnd.Next(5, 40);

            lblBanaan.Content = aantalBananen + " over";
            lblBoter.Content = aantalBoter + " over";
            lblEieren.Content = aantalEieren + " over";

            btnAfrekenen.IsEnabled = false;

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            btnAfrekenen.IsEnabled = false;
            Lijst.Items.Clear();
            Random rnd = new Random();
            aantalBananen = rnd.Next(5, 40);
            aantalEieren = rnd.Next(5, 40);
            aantalBoter = rnd.Next(5, 40);

            lblBanaan.Content = aantalBananen + " over";
            lblBoter.Content = aantalBoter + " over";
            lblEieren.Content = aantalEieren + " over";

        }


        private void btnBanaan_Click(object sender, RoutedEventArgs e)
        {

            aantalBananen--;
            lblBanaan.Content = aantalBananen + " over";
            totaal += PRIJS_BANAAN;
            Lijst.Items.Add($"{PRIJS_BANAAN} - 1 tros bananen");
            btnAfrekenen.IsEnabled = true;
        }


        private void btnBoter_Click(object sender, RoutedEventArgs e)
        {
            aantalBoter--;
            lblBoter.Content = aantalBoter + " over";
            totaal += PRIJS_BOTER;
            Lijst.Items.Add($"{PRIJS_BOTER} - 1 pak Boter ");
            btnAfrekenen.IsEnabled = true;
        }

        private void btnEieren_Click(object sender, RoutedEventArgs e)
        {
            aantalEieren--;
            lblEieren.Content = aantalEieren + " over";
            totaal += PRIJS_EIEREN;
            Lijst.Items.Add($"{PRIJS_EIEREN} - 1 doos eieren");
            btnAfrekenen.IsEnabled = true;
        }

        private void btnAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            lblTotaalPrijs.Content = Math.Round(Convert.ToDouble(totaal), 2) + " euro";
            Lijst.Items.Clear();
        }
    }
}
