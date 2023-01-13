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
                lblTotaalprijs.Content = 85000;
            }

            else if (CmbModel.SelectedIndex == 1)
            {
                lblTotaalprijs.Content = 72000;
            }

            else if (CmbModel.SelectedIndex == 2)
            {
                lblTotaalprijs.Content = 65300;
            }

        }
    }
}
