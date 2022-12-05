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

namespace WpfAlcohol
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

        
        private void sldBier_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            sldBier.IsSnapToTickEnabled = true;
            lblBier.Content = sldBier.Value + "glazen";
            rctTotaal.Width = sldBier.Value + sldWijn.Value + sldWhiskey.Value;
            
        }

        private void sldWijn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sldWijn.IsSnapToTickEnabled = true;
            lblWijn.Content = sldWijn.Value + " glazen";
            rctTotaal.Width = sldBier.Value + sldWijn.Value + sldWhiskey.Value;
            
        }

        private void sldWhiskey_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sldWhiskey.IsSnapToTickEnabled = true;
            lblWhiskey.Content = sldWhiskey.Value + " glazen";
            rctTotaal.Width = sldBier.Value + sldWijn.Value+ sldWhiskey.Value;
            
        }
    }
}
