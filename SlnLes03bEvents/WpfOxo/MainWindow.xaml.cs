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

namespace WpfOxo
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
        
       


        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string symbool = (string) btn.Content;
            int Speler1 = 1;
            int Speler2 = 2;    

            if (Speler1 == 1)
            {
                btn.Content = "X";
            }
            else 
            {
                btn.Content = "O";
            }
            
            
            /*
            if (input == "X")
            {  
                input.Replace('X', 'O');
            }
            else if (input == "O")
            {
                input.Replace('O', 'X');
            }
            */

        }


    }
}
