using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Resources;
using System.Threading;

namespace WpfSequenceGame
{
    /// <summary>
    /// Interaction logic for game.xaml
    /// </summary>
    public partial class game : Window
    {
        Random random;
        List<int> pattern;
        int numRounds;
        int actualRound;
        List<int> input;
        int score = 0;
        string naam;

        public game(string naam, int rounds)
        {
            InitializeComponent();
            lblNaam.Content = "Welcome " + naam;
            this.naam = naam;
            random = new Random();
            pattern = new List<int>();
            numRounds = rounds;
            actualRound = 1;
            lblRound.Content = "Actual round: " + actualRound;
            input = new List<int>();
            btnAnswer.IsEnabled = false;


        }


        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
           
            if (actualRound <= numRounds)
            {
                pattern.Add(random.Next(1, 5));

                // De sequentie wordt zichtbaar
                foreach (int color in pattern)
                {
                    lblAntwoorden.Content = (getAnimalName(color));
                    System.Threading.Thread.Sleep(2000);
                }

                btnStart.IsEnabled = false;
                btnAnswer.IsEnabled = true;
            } 
        }


        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            string[] txtSplit = TxtAnswer.Text.Split(' ');
            if (txtSplit.Length != actualRound)
            {
                TxtAnswer.BorderBrush = Brushes.Red;
                TxtAnswer.Background = Brushes.Red;
            }
            else
            {
                if (!string.IsNullOrEmpty(TxtAnswer.Text))
                {
                    string[] txtSplit1 = TxtAnswer.Text.Split(' ');
                    for (int i = actualRound - 1; i < txtSplit.Length; i++)
                    {
                        input.Add(Convert.ToInt32(txtSplit[i]));
                    }

                    if (input.SequenceEqual(pattern))
                    {
                        playSound("sounds/correctAntwoord.wav");
                        lblCheck.Content = "Correct!";
                        actualRound++;
                        lblRound.Content = "Actual Round: " + actualRound;
                        if (actualRound > numRounds)
                        {
                            int r = actualRound - 1;
                            lblRound.Content = "Actual Round: " + r;
                        }

                        score++;
                        btnStart.IsEnabled = true;
                        btnAnswer.IsEnabled = false;

                    }
                    else
                    {
                        playSound("sounds/gameover.wav");
                        lblCheck.Content = "Incorrect! Game over. Je maximale score was: " + score;
                        btnAnswer.IsEnabled = false;
                        btnStart.IsEnabled = false;
                    }

                    if (actualRound > numRounds)
                    {
                        playSound("sounds/complete.wav");
                        lblCheck.Content = "Je hebt gewonnen! ";
                        btnAnswer.IsEnabled = false;
                        btnStart.IsEnabled = false;
                        WriteFile(this.naam, numRounds);
                    }

                    TxtAnswer.Clear();
                }
                else
                {
                    TxtAnswer.BorderBrush = Brushes.Red;
                    TxtAnswer.Background = Brushes.Red;
                }

            }
        }


        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
           
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
            
        }


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


        static string playSound(string sound)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, sound);
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
            return " ";
        }


        static void WriteFile(string naam, int round)
        {

            FileStream fs = File.Open("score.txt", FileMode.Append);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                string str = "Naam:" + naam + ", Round:" + round;
                sw.WriteLine(str);
            }
        }


        /*
        private void TxtAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (!TxtAnswer.Text.Any(char.IsWhiteSpace))
            {
                TxtAnswer.Background = Brushes.IndianRed;
                lblCheck.Content = "Je moet een spatie houden tussen elk getal!";
                
            }
            else
            {
                TxtAnswer.Background = Brushes.LightGreen;
                lblCheck.Content = "";
            }
        }
        */
    }
}
