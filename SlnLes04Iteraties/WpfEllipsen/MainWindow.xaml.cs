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

namespace WpfEllipsen
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

        Ellipse newEllipse = new Ellipse();
        Random rnd = new Random();
        private void SldAantalCirkels_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblAantalCirkels.Content = sldAantalCirkels.Value;
        }

        private void SldMinimumRadius_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblMinimumRadius.Content = sldMinimumRadius.Value;
        }

        private void SldMaximumRadius_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblMaximumRadius.Content = sldMaximumRadius.Value;
        }

        private void BtnTekenen_Click(object sender, RoutedEventArgs e)
        {
            
            int aantalEllipsen = Convert.ToInt32(sldAantalCirkels.Value);  
            int minRadius = Convert.ToInt32(sldMinimumRadius.Value);
            int maxRadius = Convert.ToInt32(sldMaximumRadius.Value);


            for (int i = 0; i < aantalEllipsen; i++)
            {
                newEllipse.Width =  maxRadius;
                newEllipse.Height = minRadius; 
                newEllipse.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255)));
                double xPos = rnd.Next(10,700);
                double yPos = rnd.Next(10,250);
                newEllipse.SetValue(Canvas.LeftProperty, xPos);
                newEllipse.SetValue(Canvas.TopProperty, yPos);

                
            }

            canvas1.Children.Add(newEllipse);
        }

    }
}
