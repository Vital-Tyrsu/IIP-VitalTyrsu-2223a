using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string naam = Console.ReadLine();
            int aantalklinkers = 0;

            int letterNaarGetal;

            foreach (char klinker in naam)
            {
                if (klinker == 'a' || klinker == 'e' || klinker == 'i' || klinker == 'o' || klinker == 'u')
                {
                    aantalklinkers++;
                }
            }
            foreach (char karakter in naam)
            {
                letterNaarGetal = Convert.ToInt32(karakter);
                letterNaarGetal = letterNaarGetal + 1;
                naam = Convert.ToString(letterNaarGetal);
                naam = Char.ConvertFromUtf32(karakter + 1);
                Console.WriteLine(naam);
            }
            
            Console.WriteLine($"Deze tekst bevat {aantalklinkers} klinkers");

           

            Console.ReadLine();
        }
    }

    //
}
