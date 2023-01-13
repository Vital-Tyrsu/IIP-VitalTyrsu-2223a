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

namespace WpfCarConfigurator
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
        
        private void CmbModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (CmbModel.SelectedIndex == 0)
            {
                if (RadioBlauw.IsChecked == true)
                {
                    img.Source = new BitmapImage(new Uri("images/model1_blauw.jpg", UriKind.Relative));
                    int prijsBlauw = 85000;
                    lblTotaalprijs.Content = Convert.ToString(prijsBlauw);
                }
                else if (RadioGroen.IsChecked == true)
                {
                    img.Source = new BitmapImage(new Uri("images/model1_groen.jpg", UriKind.Relative));
                    int prijsGroen = 85250;
                    lblTotaalprijs.Content = Convert.ToString(prijsGroen);
                }
                else if (RadioRood.IsChecked == true)
                {
                    img.Source = new BitmapImage(new Uri("images/model1_rood.jpg", UriKind.Relative));
                    int prijsRood = 85700;
                    lblTotaalprijs.Content = Convert.ToString(prijsRood);
                }
            }
             else if (CmbModel.SelectedIndex == 1)
            {
                if (RadioBlauw.IsChecked == true)
                {
                    img.Source = new BitmapImage(new Uri("images/model2_blauw.jpg", UriKind.Relative));
                    int prijsBlauw = 72000;
                    lblTotaalprijs.Content = Convert.ToString(prijsBlauw);
                }
                else if (RadioGroen.IsChecked == true)
                {
                    img.Source = new BitmapImage(new Uri("images/model2_groen.jpg", UriKind.Relative));
                    int prijsGroen = 72250;
                    lblTotaalprijs.Content = Convert.ToString(prijsGroen);
                }
                else if (RadioRood.IsChecked == true)
                {
                    img.Source = new BitmapImage(new Uri("images/model2_rood.jpg", UriKind.Relative));
                    int prijsRood = 72700;
                    lblTotaalprijs.Content = Convert.ToString(prijsRood);
                }
            }
            else if (CmbModel.SelectedIndex == 2)
            {
                if (RadioBlauw.IsChecked == true)
                {
                    img.Source = new BitmapImage(new Uri("images/model3_blauw.jpg", UriKind.Relative));
                    int prijsBlauw = 65300;
                    lblTotaalprijs.Content = Convert.ToString(prijsBlauw);
                }
                else if (RadioGroen.IsChecked == true)
                {
                    img.Source = new BitmapImage(new Uri("images/model3_groen.jpg", UriKind.Relative));
                    int prijsGroen = 65300 + 250;
                    lblTotaalprijs.Content = Convert.ToString(prijsGroen);
                }
                else if (RadioRood.IsChecked == true)
                {
                    img.Source = new BitmapImage(new Uri("images/model3_rood.jpg", UriKind.Relative));
                    int prijsRood = 65300 + 700;
                    lblTotaalprijs.Content = Convert.ToString(prijsRood);
                }
            }
            
        } 

        private void RadioBlauw_Checked(object sender, RoutedEventArgs e)
        {
           
        }


        private void RadioGroen_Checked(object sender, RoutedEventArgs e)
        {
            // code to update the image based on the selected color
        }

        private void RadioRood_Checked(object sender, RoutedEventArgs e)
        {
            // code to update the image based on the selected color
        }


    }
}
