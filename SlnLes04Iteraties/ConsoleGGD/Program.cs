using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGGD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEREKEN GROOTST GEMENE DELER");
            Console.WriteLine("============================");
            Console.Write("Getal 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            Console.WriteLine("De grootst gemene deler is: " + a);
            Console.ReadLine();
        }
    }
}

