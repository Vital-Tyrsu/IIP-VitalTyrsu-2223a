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

namespace WpfPizza
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

        private void rdbHotSpicy_Checked(object sender, RoutedEventArgs e)
        {
            txtBeschrijving.Text = "Tomatensaus, mozzarella, ui, kip, paprika, pepperoni";
            imgPhoto.Source = new BitmapImage(new Uri("img/PizzaHotAndSpicy.jpg", UriKind.Relative));

        }

        private void rdbVierSeizoenen_Checked(object sender, RoutedEventArgs e)
        {
            txtBeschrijving.Text = "Tomatensaus, mozzarella, pepperoni, gegrilde ham, paprika";
            imgPhoto.Source = new BitmapImage(new Uri("img/PizzaVierSeizoenen.jpg", UriKind.Relative));
        }

        private void rdbHawai_Checked(object sender, RoutedEventArgs e)
        {
            txtBeschrijving.Text = "Tomatensaus, mozzarella, ham, ananas & extra mozzarella";
            imgPhoto.Source = new BitmapImage(new Uri("img/PizzaHawai.jpg", UriKind.Relative));
        }
    }
}
