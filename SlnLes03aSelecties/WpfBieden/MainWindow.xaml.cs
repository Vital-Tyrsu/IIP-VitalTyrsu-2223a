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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int hoogsteBod = 0;
        string naamMetHoogsteBod;



        public MainWindow()
        {
            InitializeComponent();
            imgPhoto.Source = new BitmapImage(new Uri("img/Vaas.jpg", UriKind.Relative));
        }

        
        private void btnBod_Click(object sender, RoutedEventArgs e)
        {
           
            int nieuwBod = Convert.ToInt32(TxtBod.Text);

            if  (nieuwBod > hoogsteBod)
            {
                lblAntwoord.Content = $"{TxtNaam.Text} heeft met {nieuwBod} euro nu het hoogste bod!";
                hoogsteBod = nieuwBod; 
                naamMetHoogsteBod = TxtNaam.Text;
            }
            else
            {
                lblAntwoord.Content = $"Sorry, {naamMetHoogsteBod} heeft momenteel het hoogste bod!";
            }
        }
    }
}
