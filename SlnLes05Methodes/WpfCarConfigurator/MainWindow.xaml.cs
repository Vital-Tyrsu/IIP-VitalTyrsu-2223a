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

        public class CarData
        {
            public string ImagePath { get; set; }
            public int Price { get; set; }
        }

        private void CmbModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedModel = CmbModel.SelectedItem.ToString();
            string selectedColor = "";
            if (RadioBlauw.IsChecked == true)
            {
                selectedColor = "Blauw";
            }
            else if (RadioGroen.IsChecked == true)
            {
                selectedColor = "Groen";
            }
            else if (RadioRood.IsChecked == true)
            {
                selectedColor = "Rood";
            }
            CarData carData = GetCarData(selectedModel, selectedColor);
            img.Source = new BitmapImage(new Uri(carData.ImagePath, UriKind.Relative));
            lblTotaalprijs.Content = carData.Price.ToString();
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


        private int GetCarData(string model, string color)
        {
            CarData carData = new CarData();
            switch (model)
            {
                case "Model1":
                    switch (color)
                    {
                        case "Blauw":
                            carData.ImagePath = "images/model1_blauw.jpg";
                            carData.Price = 85000;
                            break;
                        case "Groen":
                            carData.ImagePath = "images/model1_groen.jpg";
                            carData.Price = 85250;
                            break;
                        case "Rood":
                            carData.ImagePath = "images/model1_rood.jpg";
                            carData.Price = 85700;
                            break;
                    }
                    break;
                case "Model2":
                    switch (color)
                    {
                        case "Blauw":
                            carData.ImagePath = "images/model2_blauw.jpg";
                            carData.Price = 72000;
                            break;
                        case "Groen":
                            carData.ImagePath = "images/model2_groen.jpg";
                            carData.Price = 72250;
                            break;
                        case "Rood":
                            carData.ImagePath = "images/model2_rood.jpg";
                            carData.Price = 72700;
                            break;
                    }
                    break;
                case "Model3":
                    switch (color)
                    {
                        case "Blauw":
                            carData.ImagePath = "images/model3_blauw.jpg";
                            carData.Price = 65300;
                            break;
                        case "Groen":
                            carData.ImagePath = "images/model3_groen.jpg";
                            carData.Price = 65300 + 250;
                            break;
                        case "Rood":
                            carData.ImagePath = "images/model3_rood.jpg";
                            carData.Price = 65300 + 700;
                            break;
                    }
                    break;
            }
            return carData;

        }
        }
    }
