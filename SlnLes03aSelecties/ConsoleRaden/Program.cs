using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 7;
            Console.Write("Raad een getal tussen 1 en 10: ");
            getal = Convert.ToInt32(Console.ReadLine());

            if (getal > 7)
            {
                Console.WriteLine("De gok was te hoog");
            }
            else if (getal < 7)
            {
                Console.WriteLine("De gok was te laag");
            }
            else
            {
                Console.WriteLine("Je gok is correct!");
            }
            Console.ReadLine();
        }
    }
}
