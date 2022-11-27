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

            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");

            Console.Write("Lengte (in cm): ");
            double lengte = Convert.ToInt32(Console.ReadLine());
            lengte = lengte / 100;
            Console.Write("Gewicht (in kg): ");
            int gewicht = Convert.ToInt32(Console.ReadLine());

            double totaal = Math.Round(Convert.ToDouble(gewicht) / (lengte * lengte), 2);

            Console.Write("Je BMI bedraagt: " + totaal);

            Console.ReadLine();

        }
    }
}
