using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHalloWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Wereld");
            Console.Write("Hoe heet je: ");
            string antwoord = Console.ReadLine();
            Console.WriteLine($"Aangename kennismaking, {antwoord}.");
            Console.WriteLine("druk een toets om verder te gaan...");
            Console.ReadKey();
        }
    }
}
