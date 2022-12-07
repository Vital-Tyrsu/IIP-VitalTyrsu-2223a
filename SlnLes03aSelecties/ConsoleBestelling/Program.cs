using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestelling
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double prijs = 0;

            Console.WriteLine("PIZZA BESTELLING");
            Console.WriteLine("================");

            Console.WriteLine(@"Kies je pizza: 
a) Margherita 8 euro
b) Funghi 10 euro
c) Diabolo 11 euro
d) 4 seizoenen 13 euro
>> wat is je keuze? ");
            char keuze = Convert.ToChar(Console.ReadLine());
            string pizzaKeuze = " ";
            switch (keuze)
            {
                case 'a': pizzaKeuze = "Margherita"; prijs = 8;
                    break;
                case 'b': pizzaKeuze = "Funghi"; prijs = 10;
                    break;
                case 'c': pizzaKeuze = "Diabolo"; prijs = 11;
                    break;
                case 'd': pizzaKeuze = "4 seizoenen"; prijs = 13;
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }

            Console.WriteLine(@"Kies de grootte:
a) 15 cm (klein; - 20%)
b) 20 cm (normaal)
c) 25 cm (groot; + 20%)
d) 45 cm (Big King XXL; +50%)
>> wat is je keuze? ");
            char grootte = Convert.ToChar(Console.ReadLine());
            string pizzaGrootte = " ";
            switch (grootte)
            {
                case 'a':
                    pizzaGrootte = "klein"; prijs = prijs * 0.8;
                    break;
                case 'b':
                    pizzaGrootte = "normaal";
                    break;
                case 'c':
                    pizzaGrootte = "groot"; prijs *= 1.2;
                    break;
                case 'd':
                    pizzaGrootte = "Big King XXL"; prijs *= 1.7;
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }

            Console.Write("Thuis bezorgen (3 euro extra)? ja/nee: ");
            string levering = Console.ReadLine();
            if (levering == "ja")
            {
                levering = "thuis bezorgd";
                prijs = prijs + 3;
            }
            else
            {
                levering = "niet thuis bezorgd";
            }

            Console.Write("Vandaag EXTRA korting ! Wens je deze nu te gebruiken of later? ja/nee: ");
            string extra = Console.ReadLine();
            if ( extra == "ja")
            {
                prijs *= 0.8;
            }
            Console.WriteLine($"Jouw bestelling: 1 pizza {pizzaKeuze} {pizzaGrootte}, voor {prijs} euro,{levering}");
            Console.ReadLine();

        }
    }
}
