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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal;
        int aantalPogingen = 3;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            getal = rnd.Next(1, 10);

        }


        private void BtnGok_Click(object sender, RoutedEventArgs e)
        {

            int antwoord = Convert.ToInt32(txtGok.Text);
            if (antwoord > getal)
            {
                aantalPogingen--;
                lblAntwoord.Content = $"Te hoog! Je hebt nog {aantalPogingen} pogingen over."; 
            }
            else if (antwoord < getal)
            {
                aantalPogingen--;
                lblAntwoord.Content = $"Te laag! Je hebt nog {aantalPogingen} pogingen over.";
            }
            else if(antwoord == getal)
            {
                lblAntwoord.Content = "Je hebt gewonnen!";
                btnOpnieuw.Visibility = Visibility.Visible;
            }
            
            
            if (aantalPogingen == 0)
            {
                btnGok.IsEnabled = false;
                lblAntwoord.Content = "Game over!";
                btnOpnieuw.Visibility = Visibility.Visible;
            }
        }

        private void BtnOpnieuw_Click(object sender, RoutedEventArgs e)
        {
            btnGok.IsEnabled = true;
            lblAntwoord.Content = "";
            aantalPogingen = 3;
            txtGok.Text = "";
            Random rnd = new Random();
            getal = rnd.Next(1, 10);
            btnOpnieuw.Visibility = Visibility.Hidden;
        }
    }
}
