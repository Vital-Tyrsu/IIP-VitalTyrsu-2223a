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

namespace WpfGebruikersnaam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void TxtGebruikersnaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtGebruikersnaam.Text.Contains(' '))
            {
                txtGebruikersnaam.Background = Brushes.LightSalmon;
                lblFoutmelding.Foreground = Brushes.Red;
                lblFoutmelding.Content = "mag geen spaties bevatten";
            }
            else if (txtGebruikersnaam.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                txtGebruikersnaam.Background = Brushes.LightSalmon;
                lblFoutmelding.Foreground = Brushes.Red;
                lblFoutmelding.Content = "mag geen speciale karakters of getallen bevatten";

            }

            else if (txtGebruikersnaam.Text.Any(char.IsDigit))
            {
                txtGebruikersnaam.Background = Brushes.LightSalmon;
                lblFoutmelding.Foreground = Brushes.Red;
                lblFoutmelding.Content = "mag geen speciale karakters of getallen bevatten";
            }

            else
            {
                txtGebruikersnaam.Background= Brushes.LightGreen;
                lblFoutmelding.Content = "";
            }
        }
    }
}
