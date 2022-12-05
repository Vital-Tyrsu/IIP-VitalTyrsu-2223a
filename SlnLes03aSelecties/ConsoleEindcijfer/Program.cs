using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berekening eindcijfer");
            Console.WriteLine("=====================");

            Console.Write("Geef het cijfer dagelijks werk (op 20): ");
            double dagelijksWerkCijfer = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geef het cijfer op het project (op 20): ");
            double projectCijfer = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geef het cijfer op het examen (op 20): ");
            double examenCijfer = Convert.ToDouble(Console.ReadLine());

            double eindCijfer = Math.Round((dagelijksWerkCijfer * 0.3) + (projectCijfer * 0.2) + (examenCijfer * 0.5), 1) * 5;
            Console.WriteLine($"Je eindcijfer is {eindCijfer}%");

            if (eindCijfer > 82.5)
            {
                Console.WriteLine("-> grootste onderscheiding");
            }
            else if (eindCijfer > 75)
            {
                Console.WriteLine("-> grote onderscheiding");
            }
            else if (eindCijfer > 67.5)
            {
                Console.WriteLine("-> onderscheiding");
            }
            else if (eindCijfer > 50)
            {
                Console.WriteLine("Voldoende");
            }
            else
            {
                Console.WriteLine("Onvoldoende");
            }

            if (examenCijfer < 8)
            {
                eindCijfer = Math.Min(eindCijfer, examenCijfer);
            }

            Console.ReadLine();
        }
    }
}
