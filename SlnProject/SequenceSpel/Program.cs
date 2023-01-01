using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SequenceSpel
{
    class Program
    {

        static void Main(string[] args)
        {
            // Initialiseer het spel



            Random random = new Random();
            List<int> pattern = new List<int>();
            int round = 1;

            Console.Write("Voer je naam in: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Hoeveel rounds wens je te spelen? ");
            int numRounds = Convert.ToInt32(Console.ReadLine());

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
                    Console.Write(GetColorName(color));
                    Console.Write(" ");
                    System.Threading.Thread.Sleep(500);
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
                    Console.Beep(2000, 500);
                    Console.WriteLine("Correct!");
                    round++;
                }
                else
                {
                    Console.Beep(50, 500);
                    Console.WriteLine("Incorrect! Game over. Je maximale score was: " + round++);
                    break;
                }

                if (round > numRounds)
                {
                    Console.WriteLine("Je hebt gewonnen! ");
                }

              
            }


            
            Console.ReadLine();
        }


        // Methode
        static string GetColorName(int color)
        {
            if (color == 1)
            {
                Console.Beep(1000, 500);
                return "Red";
            }
            else if (color == 2)
            {
                Console.Beep(250, 500);
                return "Blue";
            }
            else if (color == 3)
            {
                Console.Beep(500, 500);
                return "Green";
            }
            else
            {
                Console.Beep(750, 500);
                return "Yellow";
            }
        }

        static void ColorText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Rood = 1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blauw = 2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Groen = 3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Geel = 4");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

