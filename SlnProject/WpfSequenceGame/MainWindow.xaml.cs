using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
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

namespace WpfSequenceGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        List<int> pattern = new List<int>();
        int round = 1;

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            TxtNaam.Text = Console.ReadLine();
            int numRounds = Convert.ToInt32(TxtRounds.Text);

            while (round <= numRounds)
            {
                pattern.Add(random.Next(1, 5));
                foreach (int color in pattern)
                {
                    TxtSequencePattern.Text = (getAnimalName(color) + " ");
                    System.Threading.Thread.Sleep(2000);
                }

                List<int> input = new List<int>();
                while (input.Count < pattern.Count)
                {
                    string key = Console.ReadLine();
                    if (key == "1")
                    {
                        input.Add(1);
                    }
                    else if (key == "2")
                    {
                        input.Add(2);
                    }
                    else if (key == "3")
                    {
                        input.Add(3);
                    }
                    else if (key == "4")
                    {
                        input.Add(4);
                    }
                }
            }
        }


        static string playSound(string sound)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, sound);
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
            return " ";
        }

        // Methode
        static string getAnimalName(int keuze)
        {
            if (keuze == 1)
            {
                return playSound("sounds/hond.wav");
            }
            else if (keuze == 2)
            {
                return playSound("sounds/koe.wav");
            }
            else if (keuze == 3)
            {
                return playSound("sounds/kuikentje.wav");
            }
            else
            {
                return playSound("sounds/paard.wav");
            }
        }
    }
}
