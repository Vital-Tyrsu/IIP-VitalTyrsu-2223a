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

namespace djflkqjdfgoiqnrgoin
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            int lengte = Convert.ToInt32(txtLengte.Text);
            int gewicht = Convert.ToInt32(txtGewicht.Text);

            double lengteInMeter = (double)lengte / 100;
            double bmi = (double)gewicht / Math.Pow(lengteInMeter, 2);
            lblBMI.Content = bmi.ToString("0.0");
        }
    }
}
