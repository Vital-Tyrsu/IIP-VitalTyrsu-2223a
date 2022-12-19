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

namespace WpfBoodschappenlijst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string lijst;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void LstBoodschappen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            foreach (ListBoxItem item in LstBoodschappen.SelectedItems)
            {
                lijst = Convert.ToString(item.Content);

            }
            lblSelectie.Content += " " + lijst;


        }
    }
}
