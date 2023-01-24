using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFibonnaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel Fibonacci getallen wil je afdrukken: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            int[] reeks = new int[getal];

            reeks[0] = 1;
            reeks[1] = 1;

            for (int i = 2; i < reeks.Length; i++)
            {
                reeks[i] = reeks[i - 1] + reeks[i - 2];
            }

            Console.Write($"Eerste {reeks.Length} Fibonnaci getallen : ");
            for (int i = 0; i < reeks.Length; i++)
            {
                Console.Write(" " + reeks[i]);
            }

            Console.ReadLine();
        }
    }
}
