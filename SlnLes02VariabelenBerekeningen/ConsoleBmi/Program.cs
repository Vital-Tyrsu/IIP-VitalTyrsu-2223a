using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("@BMI CALCULATOR\n===============");
            Console.Write("Lengte (in cm): ");
            int lengte = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gewicht (in kg): ");
            int gewicht = Convert.ToInt32(Console.ReadLine());

            double lengteInMeter = (double)lengte / 100;

            double bmi = (double)gewicht / Math.Pow(lengteInMeter , 2);

            Console.WriteLine($"Je BMI bedraagt:{bmi.ToString("0.0")} ");
            Console.ReadLine();
        }
    }
}
