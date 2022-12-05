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


namespace WpfSliderKleur
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

        private void sldKleur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblGetal.Content = sldKleur.Value;

            if (sldKleur.Value <= 25)
            {
                lblGetal.Foreground = Brushes.Green;
            }
            else if (sldKleur.Value <=50)
            {
                lblGetal.Foreground = Brushes.Yellow;
            }
            else if (sldKleur.Value <=75)
            {
                lblGetal.Foreground = Brushes.Orange;
            }
            else
            {
                lblGetal.Foreground= Brushes.Purple;
            }
        }
    }
}
