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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int eersteGetal;
        int tweedeGetal;
        int totaal;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOptellen_Click(object sender, RoutedEventArgs e)
        {
            eersteGetal = Convert.ToInt32(Button.ContentProperty);
            tweedeGetal = Convert.ToInt32(((TextBox)sender).Text);

            totaal = eersteGetal + tweedeGetal;
            lblUitkomst.Content = totaal;
        }
    }
}
