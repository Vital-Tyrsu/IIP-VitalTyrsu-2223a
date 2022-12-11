using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel seconden tot lancering? ");
            int getal = Convert.ToInt32(Console.ReadLine());
            for (int i = getal; i > 0; i--)
            {
                Console.WriteLine($"{i}...");

                if (i == 1)
                {   
                    Console.WriteLine("Lift off!");
                }

                Task.Delay(1000).Wait();
                
            }
            Console.ReadLine();
        }
    }
}
