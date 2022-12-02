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

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"Aantal seizoensbuffets ({euro}18.5): ");
            int aantalSeizoen = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Aantal dessertenbuffets ({euro}7.95): ");
            int aantalDesserten = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Aantal kids menus ({euro}8.95): ");
            int aantalKinder = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fooi (0 indien geen): ");
            double fooi = Convert.ToDouble(Console.ReadLine());

            double totaal = (aantalSeizoen * SEIZOENBUFFET) + (aantalDesserten * DESSERTENBUFFET) + (aantalKinder*KINDERMENU)+ fooi;
            Console.WriteLine($"Totaal te betalen: {totaal}");
            double prijsAfgerond = Math.Floor(totaal);
            Console.WriteLine($"Afgerond naar {prijsAfgerond}");

            Console.WriteLine("");
            
            Console.WriteLine("Cash betaald:");
            int prijsBetaald= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("U krijgt terug: ");
            double prijsTotaal = (prijsAfgerond - prijsBetaald);


            prijsTotaal = prijsTotaal / 50;
            prijsTotaal = prijsTotaal % 50;
            Console.WriteLine($"- {prijsTotaal} briefje(s) van 50");

            prijsTotaal = prijsTotaal / 20;
            prijsTotaal = prijsTotaal % 20;
            Console.WriteLine($"- {prijsTotaal} briefje(s) van 20");
            

            Console.WriteLine($"- {prijsTotaal} briefje(s) van 10");
            

            Console.WriteLine($"- {prijsTotaal} briefje(s) van 5");
            

            Console.WriteLine($"- {prijsTotaal} stuk(ken) van 2");
            

            Console.WriteLine($"- {prijsTotaal} stuk(ken) van 1");
            



            Console.ReadLine();
        }
    }
}
