using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace ColorSequenceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of possible colors
            List<string> colors = new List<string> { "red", "orange", "yellow", "green", "blue", "purple" };

            // Randomly select a sequence of colors
            Random rnd = new Random();
            List<string> sequence = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                sequence.Add(colors[rnd.Next(colors.Count)]);
            }

            // Prompt the user to repeat the sequence
            Console.WriteLine("Remember the following color sequence:");
            foreach (string color in sequence)
            {
                Console.Write(color + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Enter the color sequence, separated by spaces:");
            string[] input = Console.ReadLine().Split(' ');

            // Check if the user's input matches the sequence
            bool correct = true;
            for (int i = 0; i < sequence.Count; i++)
            {
                if (input[i] != sequence[i])
                {
                    correct = false;
                    break;
                }
            }

            if (correct)
            {
                Console.WriteLine("Correct! You remembered the sequence.");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct sequence was:");
                foreach (string color in sequence)
                {
                    Console.Write(color + " ");
                }
            }
            Console.ReadLine();
        }
    }
}

