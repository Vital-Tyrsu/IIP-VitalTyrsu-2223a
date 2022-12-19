using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTemperatuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;
            double kelvin;
            char keuze = ' ';


            Console.WriteLine("TEMPERATUUR CONVERSIE");
            Console.WriteLine("=====================");

            Console.WriteLine(@"
a. Celsius naar Fahrenheit
b. Fahrenheit naar Celsius
c. Celsius naar Kelvin
d. Kelvin naar Celsius
x. Afsluiten");
            while (keuze != 'x')
            {
                Console.Write("Maak je keuze: ");
                keuze = Convert.ToChar(Console.ReadLine());
                if (keuze == 'a')
                {
                    Console.Write("Celsius: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("-> naar Fahrenheit: ");
                }
                if (keuze == 'b')
                {
                    Console.Write("Fahrenheit: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("-> naar Celsius: ");
                }
                if (keuze == 'c')
                {
                    Console.Write("Celsius: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("-> naar Kelvin: ");
                }
                if (keuze == 'd')
                {
                    Console.Write("Kelvin: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("-> naar Celsius: ");
                }
            }
            Console.WriteLine("Bedankt en tot ziens!");
           
            Console.ReadLine();
        }
    }
}
