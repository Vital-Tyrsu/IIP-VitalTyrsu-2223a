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

namespace WpfTodo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnVerwijderen.IsEnabled = false;
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtTodo.Text) == false)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = txtTodo.Text;
                if (cmbTodo.SelectedIndex == 0)
                {
                    item.Foreground = new SolidColorBrush(Colors.Green);
                }
                else if (cmbTodo.SelectedIndex == 1)
                {
                    item.Foreground = new SolidColorBrush(Colors.Orange);
                }
                else if (cmbTodo.SelectedIndex == 2)
                {
                    item.Foreground = new SolidColorBrush(Colors.Red);
                }
                lstTodo.Items.Add(item);
                btnVerwijderen.IsEnabled = true;
            }

        }


        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            lstTodo.Items.Remove(lstTodo.SelectedItem);

            if (lstTodo.Items.Count == 0)
            {
                btnVerwijderen.IsEnabled = false;
            }
        }


    }
}

