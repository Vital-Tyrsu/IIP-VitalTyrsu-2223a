using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char euro = Convert.ToChar('\u20AC');
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"WELKOM IN HET BUFFETRESTAURANT
==============================

Alles is à volonté en dranken zijn inbegrepen!
!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!");

            const double SEIZOENBUFFET = 18.5;
            const double DESSERTENBUFFET = 7.95;
            const double KINDERMENU = 8.95;

            Console.Write($"Aantal seizoensbuffets ({euro}18.5):");
            Console.Write($"Aantal dessertenbuffets ({euro}7.95):");

            Console.WriteLine("Fooi (0 indien geen): ");
            

            Console.ReadLine();
        }
    }
}
