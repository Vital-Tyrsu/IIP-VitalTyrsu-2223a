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

namespace WpfInterest
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sldPeriode.IsSnapToTickEnabled = true;
            lblYear.Content = sldPeriode.Value + " jaar";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int bedrag = Convert.ToInt32(txtEuro.Text);
            double interest = Convert.ToDouble(txtIntrest.Text);
            int lblJaar = Convert.ToInt32(sldPeriode.Value);
            double totaal = Math.Round(Convert.ToDouble(bedrag * Math.Pow((1 + (interest / 100)), lblJaar)), 2);
            lblAnswer.Content = $"De waarde na {lblYear.Content} bedraagt €{totaal}";
        }
    }
}
