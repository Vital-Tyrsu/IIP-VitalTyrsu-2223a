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

namespace WpfPriemgetal
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

        
        private void BtnAntwoord_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(txtAntwoord.Text);
            int deler = getal / 2;
            if (getal % deler != 0 && deler > 1)
            {
                lblAntwoord.Foreground = Brushes.Green;
                lblAntwoord.Content = $"{getal} is een Priemgetal";
            }
            else
            {
                lblAntwoord.Foreground = Brushes.Red;
                lblAntwoord.Content = $"{getal} is géén priemgetal";
            }
           
        }
    }
}
