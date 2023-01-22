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
using System.Windows.Resources;
using WMPLib;
using System.Drawing;
using System.IO;

namespace WpfSequenceGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            playSound("sounds/lifeStrange.wav");
        }

        Random random = new Random();
        List<int> pattern = new List<int>();
        int round = 1;

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNaam.Text) && !string.IsNullOrEmpty(TxtRounds.Text))
            {
                string naam = TxtNaam.Text;
                int rounds = Convert.ToInt32(TxtRounds.Text);
                game game = new game(naam, rounds);
                game.Show();
                this.Close(); // mainwindow sluiten
            }
            else
            {
                if (string.IsNullOrEmpty(TxtNaam.Text))
                {
                    TxtNaam.BorderBrush = Brushes.IndianRed;
                    TxtNaam.Background = Brushes.IndianRed;
                    lblAlertNaam.Content = "Naam moet ingevuld zijn!";

                }

                if (string.IsNullOrEmpty(TxtRounds.Text))
                {
                    TxtRounds.BorderBrush = Brushes.IndianRed;
                    TxtRounds.Background = Brushes.IndianRed;
                    lblAlertRound.Content = "Aantal rounds moet ingevuld worden";
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

        private void btnSeeScores_Click(object sender, RoutedEventArgs e)
        {
            score score = new score();
            readFile(score.lstNames);
            score.Show();

        }

        static void readFile(ListView List)
        {


            using (StreamReader reader = new StreamReader("score.txt"))
            {
                // Maak een lijst om elke regel van het bestand op te slaan
                List<string[]> lines = new List<string[]>();

                // Lees elke regel van het bestand totdat je het einde van het bestand bereikt
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // ik gebruik de methode ToSplit om de lijn op te splitsen in meerdere delen op basis van een komma
                    string[] parts = line.Split(',');
                    lines.Add(parts);
                }


                // Hier gebruik ik de methode Sort
                lines.Sort((b, a) =>
                {
                    // Haal de waarde op van het tweede deel van elke regel getal na de "round:"
                    string roundA = a[1].Split(':')[1];
                    string roundB = b[1].Split(':')[1];

                    // Hier zorg ik dan voor een convert van mijn waarden
                    int roundANum = int.Parse(roundA);
                    int roundBNum = int.Parse(roundB);
                    return roundANum.CompareTo(roundBNum);

                });

                foreach (string[] parts in lines)
                {
                    List.Items.Add(string.Join(", ", parts));
                    Console.WriteLine(string.Join(", ", parts));
                }

            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);

        }

        private void TxtNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNaam.Text))
            {
                TxtNaam.BorderBrush = Brushes.IndianRed;
                TxtNaam.Background = Brushes.IndianRed;
                lblAlertNaam.Content = "Naam moet ingevuld zijn!";

            }
            else if (TxtNaam.Text.Any(ch => char.IsDigit(ch)))
            {
                TxtRounds.BorderBrush = Brushes.IndianRed;
                TxtRounds.Background = Brushes.IndianRed;
                lblAlertNaam.Content = "Naam mag geen getal bevatten";
            }
            else
            {
                TxtNaam.Background = Brushes.LightGreen;
                TxtNaam.BorderBrush = Brushes.LightGreen;
                lblAlertNaam.Content = "";
            }
        }

        private void TxtRounds_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (string.IsNullOrEmpty(TxtRounds.Text))
            {
                TxtRounds.BorderBrush = Brushes.IndianRed;
                TxtRounds.Background = Brushes.IndianRed;
                lblAlertRound.Content = "Aantal rounds moet ingevuld worden";
            }
            else if (TxtRounds.Text.Any(ch => !char.IsDigit(ch)))
            {
                TxtRounds.BorderBrush = Brushes.IndianRed;
                TxtRounds.Background = Brushes.IndianRed;
                lblAlertRound.Content = "Aantal rounds mag geen letter zijn";
            }

            else
            {
                TxtRounds.Background = Brushes.LightGreen;
                TxtRounds.BorderBrush = Brushes.LightGreen;
                lblAlertRound.Content = "";
            }
        }

        private void btnMute_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer muziek = new SoundPlayer();
            playSound("sounds/lifeStrange.wav");
            muziek.Stop();

            btnMute.Visibility = Visibility.Hidden;
            btnUnmute.Visibility = Visibility.Visible;
        }

        private void btnUnmute_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer muziek = new SoundPlayer();
            playSound("sounds/lifeStrange.wav");
            muziek.Play();

            btnUnmute.Visibility = Visibility.Hidden;
            btnMute.Visibility = Visibility.Visible;
        }
    }
}
