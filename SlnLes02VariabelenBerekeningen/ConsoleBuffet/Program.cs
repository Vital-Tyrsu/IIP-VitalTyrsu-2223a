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
            int prijsTotaal = Convert.ToInt32(prijsAfgerond - prijsBetaald);


            int prijsVoor50 = prijsTotaal / 50;
            prijsTotaal = prijsTotaal % 50;
            Console.WriteLine($"- {prijsVoor50} briefje(s) van 50");

            int prijsVoor20 = prijsVoor50 / 20;
            prijsTotaal = prijsTotaal % 20;
            Console.WriteLine($"- {prijsVoor20} briefje(s) van 20");

            int prijsVoor10 = prijsVoor20 / 10;
            prijsTotaal = prijsTotaal % 10;
            Console.WriteLine($"- {prijsVoor10} briefje(s) van 10");

            int prijsVoor5 = prijsVoor10 / 5;
            Console.WriteLine($"- {prijsVoor5} briefje(s) van 5");

            int prijsVoor2 = prijsVoor5 / 2;
            Console.WriteLine($"- {prijsVoor2} stuk(ken) van 2");

            int prijsVoor1 = prijsVoor2 / 1;
            Console.WriteLine($"- {prijsVoor1} stuk(ken) van 1");
            



            Console.ReadLine();
        }
    }
}
