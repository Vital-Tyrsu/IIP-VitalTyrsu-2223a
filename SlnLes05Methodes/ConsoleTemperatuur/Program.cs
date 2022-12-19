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
            double getal;
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
                    getal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"-> naar Fahrenheit: {CelsiusFahrenheit(getal)}");
                }
                if (keuze == 'b')
                {
                    Console.Write("Fahrenheit: ");
                    getal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"-> naar Celsius: {FahrenheitCelsius(getal)} ");
                }
                if (keuze == 'c')
                {
                    Console.Write("Celsius: ");
                    getal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"-> naar Kelvin: {CelsiusKelvin(getal)}");
                }
                if (keuze == 'd')
                {
                    Console.Write("Kelvin: ");
                    getal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"-> naar Celsius: {KelvinCelsius(getal)}");
                }
            }
            Console.WriteLine("Bedankt en tot ziens!");
           
            Console.ReadLine(); 
        }
        static private double CelsiusFahrenheit(double getal1)
        {
            getal1 = Math.Round((getal1 * 1.8 + 32),2);
            return getal1;
        }

        static private double FahrenheitCelsius(double getal1)
        {
            getal1 = Math.Round(((getal1 - 32) / 1.80),2);
            return getal1;
        }

        static private double CelsiusKelvin(double getal1)
        {
            getal1 = Math.Round((getal1 + 273.15),2);
            return getal1;
        }
        static private double KelvinCelsius(double getal1)
        {
            getal1 = Math.Round((getal1 - 273.15),2);
            return getal1;
        }
    }

}
