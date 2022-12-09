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
using System.Windows.Threading;

namespace WpfProgressBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        private int count = 0;
       
        public MainWindow()
        {
            InitializeComponent();
            lblProgress.Content = count;
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
            rctProgressBar.Width = 0;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            count += 5;
            rctProgressBar.Width += 15; // Baseer je op de MaxWidth die we zelf hebben getekend
            rctProgressBar.Fill = Brushes.Green;
            lblProgress.Content = count + " %";
            if (count == 100)
            {
                MessageBox.Show("Voortgang voltooid!");
                timer.Stop();
            }
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void BtnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            lblProgress.Content = 0;
            count = 0;
            rctProgressBar.Width = 0;
        }
    }
}
