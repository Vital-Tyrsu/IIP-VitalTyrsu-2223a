using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raad een getal tussen 1 en 10");
            int getal;
            Random rnd = new Random();
            int gok = rnd.Next(1, 10);
            int aantalPogingen = 1;
           
            do
            {
                Console.Write($"Poging {aantalPogingen++}:");
                getal = Convert.ToInt32(Console.ReadLine());

                if (aantalPogingen == 4)
                {
                    Console.WriteLine("Volgende keer beter");
                    aantalPogingen = 1;
                }

            } while (getal != gok);
            Console.WriteLine("geraden!");

            Console.ReadLine();

        }
    }
}
