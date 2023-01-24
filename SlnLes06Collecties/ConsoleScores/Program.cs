using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = new int[10];
            Random rnd = new Random();

            // Generate random test scores
            for (int i = 0; i < testScores.Length; i++)
            {
                testScores[i] = rnd.Next(1, 21);
            }

            // Print the scores to the console
            for (int i = 0; i < testScores.Length; i++)
            {
                if (i == testScores.Length - 2)
                    Console.Write(testScores[i] + " en ");
                else
                    Console.Write(testScores[i]+ ", " );
            }

            // Determine the average score
            double gemiddelde = BepaalGemiddelde(testScores);
            Console.WriteLine("\nGemiddelde score is: ", Convert.ToString(gemiddelde));

            // Determine the hoogste score
            int hoogste = ZoekGrootste(testScores);
            Console.WriteLine("De beste score op de test was:" + Convert.ToString(hoogste));

            // Determine the laagste score
            int laagste = ZoekLaagste(testScores);
            Console.WriteLine("De slechtste score op de test was:" + Convert.ToString(laagste));

            Console.ReadLine();
        }

        static int ZoekGrootste(int[] scores)
        {
            int hoogste = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > hoogste)
                    hoogste = scores[i];
            }
            return hoogste;
        }

        static int ZoekLaagste(int[] scores)
        {
            int laagste = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < laagste)
                    laagste = scores[i];
            }
            return laagste;
        }

        static double BepaalGemiddelde(int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            return (double)sum / scores.Length;
        }
    }
}
