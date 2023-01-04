using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Threading;

namespace SequenceSpel
{
    class Program
    {
        // Methode
        static void readFile()
        {
            try
            {
                FileStream f = new FileStream("score.txt", FileMode.OpenOrCreate); // dient om in de files aanpassingen te maken
                using (StreamReader sr = new StreamReader(f)) // Hier dient de Streamreader om de tekst in een file te lezen
                {
                    string line;
                    // Leest de file tot het einde
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Bestand kon niet gelezen worden");
                Console.WriteLine(e.Message);
                
            }
        }

        // Methode
        static void writeFile(string naam, int round)
        {

            FileStream fs = File.Open("score.txt", FileMode.Append);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                string str = "Naam:" + naam + ", Round" + round;
                
                sw.WriteLine(str);
            }
        }


        static void Main(string[] args)
        {
            char keuze = ' ';

            Console.WriteLine("Welkom in het spel !");
            while (keuze!='c')
            {
                Console.WriteLine("Maak je keuze:");
                Console.WriteLine(@"a) Speel
b) scores bekijken
c) spel eindigen");

                keuze = Convert.ToChar(Console.ReadLine());

                // Initialiseer het spel

                Random random = new Random();
                List<int> pattern = new List<int>();
                int round = 1;
                switch (keuze)
                {
                    case 'a':
                        playSound("sounds/correct.wav");
                        Console.Write("Voer je naam in: ");
                        string naam = Console.ReadLine();
                        playSound("sounds/correct.wav");
                        Console.WriteLine("Hoeveel rounds wens je te spelen? ");
                        int numRounds = Convert.ToInt32(Console.ReadLine());
                        playSound("sounds/correct.wav");

                        ColorText();

                        // Start de game loop
                        while (round <= numRounds)
                        {
                            // Display ronde nummer
                            Console.WriteLine($"Round {round}");

                            // Nieuwe kleur toevoegen aan de pattern
                            pattern.Add(random.Next(1, 5));



                            // De sequentie wordt zichtbaar
                            foreach (int color in pattern)
                            {
                                Console.Write(GetAnimalName(color));
                                Console.Write(" ");
                                System.Threading.Thread.Sleep(2000);
                                
                            }
                            Console.WriteLine();

                            // Neemt de input op
                            List<int> input = new List<int>();
                            while (input.Count < pattern.Count)
                            {
                                char key = Console.ReadKey().KeyChar;
                                if (key == '1')
                                {
                                    input.Add(1);
                                }
                                else if (key == '2')
                                {
                                    input.Add(2);
                                }
                                else if (key == '3')
                                {
                                    input.Add(3);
                                }
                                else if (key == '4')
                                {
                                    input.Add(4);
                                }
                            }

                            // Check als input correct is
                            if (input.SequenceEqual(pattern))
                            {
                                playSound("sounds/correctAntwoord.wav");
                                Console.WriteLine("");
                                Console.WriteLine("Correct!");

                                round++;
                            }
                            else
                            {
                                playSound("sounds/gameover.wav");
                                Console.WriteLine("Incorrect! Game over. Je maximale score was: " + round++);
                                break;
                            }

                            if (round > numRounds)
                            {
                                playSound("sounds/complete.wav");
                                Console.WriteLine("Je hebt gewonnen! ");
                            }


                        }
                        writeFile(naam, round);
                        Console.ReadLine();
                        break;

                    case 'b':
                        playSound("sounds/correct.wav");
                        Console.WriteLine("Beste scores: ");
                        readFile();
                        break;

                    case 'c':
                        playSound("sounds/gameover.wav");
                        Console.WriteLine(@"
Dit programma sluit automatisch af na 3 seconden
Bedankt en tot ziens!");
                        Thread.Sleep(3000); // programma sluit zich automatisch af na 3 sec.
                        Environment.Exit(1); // men controleert als het programma effectief goed is afgesloten. Je mag je eigen getal kiezen in dit geval (1).
                        break;

                }
            }     
        }

        // Methode
        static string playSound (string sound)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, sound);
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
            return " ";
        }

        // Methode
        static string GetAnimalName(int keuze)
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

        // Methode
        static void ColorText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hond = 1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Koe = 2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kuikentje = 3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Paard = 4");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

