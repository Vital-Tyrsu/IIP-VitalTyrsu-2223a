using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnderBoven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een ondergrens: ");
            int onderGrens = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef een bovengrens: ");
            int bovenGrens = Convert.ToInt32(Console.ReadLine());

            while (bovenGrens < onderGrens || bovenGrens == onderGrens)
            {
                if (bovenGrens < onderGrens)
                {
                    Console.WriteLine("Bovengrens mag niet kleiner zijn dan ondergrens");
                }
                else if (bovenGrens == onderGrens)
                {
                    Console.WriteLine("Bovengrens mag niet gelijk zijn aan ondergrens");
                }

                Console.Write("Geef een bovengrens: ");
                bovenGrens = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine($"Bereik: van {onderGrens} tot {bovenGrens}");
            Console.ReadLine(); 
        }
    }
}
