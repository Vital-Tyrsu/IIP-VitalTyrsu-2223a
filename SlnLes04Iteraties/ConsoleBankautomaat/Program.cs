using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleBankautomaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int startBedrag = 500;
            string pinCode = "1234";
            int aantalPogingen = 2;


            Console.Write("Voer je Pincode : ");
            pinCode = Convert.ToString(Console.ReadLine());

            // Code bij niet correcte pin-code

            while (pinCode != "1234")
            {
                aantalPogingen--;
                if (pinCode.Length != 4)
                {
                    Console.WriteLine("(Code bestaat exact uit 4 cijfers)");
                }
                Console.WriteLine("Code is niet correct!");
                Console.Write("Voer je Pincode : ");
                pinCode = Convert.ToString(Console.ReadLine());

                if (aantalPogingen == 0)
                {
                    Console.WriteLine("Je kaart is Geblokkeerd. Gelieve Card Stop te bellen op 070 344 344 of contacteer uw Bankagent");
                    Console.WriteLine("Uw sessie is verlopen");
                    Thread.Sleep(3000); // programma sluit zich automatisch af na 3 sec.
                    Environment.Exit(1); // men controleert als het programma effectief goed is afgesloten. Je mag je eigen getal kiezen in dit geval (1).
                }

            }

            // Code bij Correcte pin-code

            while (pinCode == "1234")
            {
                Console.WriteLine("Bankautomaat");
                Console.WriteLine("==============================");
                Console.WriteLine("a. afhaling");
                Console.WriteLine("b. storting");
                Console.WriteLine("c. saldo bekijken");
                Console.WriteLine("d. stoppen");
                Console.Write("je keuze:");

                // Alle variabelen als je pincode correct is
                char keuze = Convert.ToChar(Console.ReadLine());
                string optie = "";
                int bedrag;

                switch (keuze)
                {
                    case 'a':
                        optie = "afhaling";
                        Console.Write("Welk bedrag wil je afhalen?: ");
                        break;
                    case 'b':
                        optie = "storting";
                        Console.Write("Welk bedrag wil je storten?: ");
                        break;
                    case 'c':
                        optie = "saldo bekijken";
                        Console.WriteLine($"Je huidige saldo staat nu op {startBedrag}");
                        break;
                    case 'd':
                        optie = "stoppen";
                        Console.WriteLine(@"
Dit programma sluit automatisch af na 3 seconden
Bedankt en tot ziens!");
                        Thread.Sleep(3000); // programma sluit zich automatisch af na 3 sec.
                        Environment.Exit(1); // men controleert als het programma effectief goed is afgesloten. Je mag je eigen getal kiezen in dit geval (1).
                        break;
                }
                

                if (optie == "afhaling")
                {
                    bedrag = Convert.ToInt32(Console.ReadLine());
                    if (bedrag <= startBedrag)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Afhaling OK - Het nieuwe saldo is {startBedrag = startBedrag - bedrag}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Afhaling Niet OK - U bevindt zich onder 0 - Gelieve te storten");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                else if (optie == "storting")
                {
                    bedrag = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Storting OK - Het nieuwe saldo is {startBedrag = startBedrag + bedrag}");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            }
            Console.ReadLine();


        }
    }
}
