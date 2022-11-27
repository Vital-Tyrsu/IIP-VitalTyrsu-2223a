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

namespace WpfBMI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Hier maak je gebruik van een double zodat je de cijfers na de komma kan lezen. 
            double lengte = Convert.ToInt32(lblLenght.Text);
            lengte = lengte / 100;
            int gewicht = Convert.ToInt32(lblGewicht.Text);

            double totaal = Math.Round(Convert.ToDouble(gewicht / (lengte * lengte)), 2);
            lblBMI.Content = ($"BMI : {totaal}");

        }
    }
}
