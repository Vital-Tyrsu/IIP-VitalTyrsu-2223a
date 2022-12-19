using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSchrikkeljaar
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int jaartal;
            Console.WriteLine("SCHRIKKELJAAR");
            Console.WriteLine("=============");
            do
            {
                Console.Write("Geef een jaartal:");
                jaartal = Convert.ToInt32(Console.ReadLine());
                if (jaartal != 0)
                {
                    Schrikkeljaar(jaartal);
                }

            } while (jaartal != 0);
            if (jaartal == 0 )
            {
                Console.WriteLine("Bedankt en tot ziens");
            }
            Console.ReadLine();
        }


        static void Schrikkeljaar(int jaartal)
        {
                if (jaartal % 4 == 0 && jaartal % 100 != 0 || jaartal % 400 == 0)
                {
                Console.WriteLine($"{jaartal} is een schrikkeljaar");
                }
                else
                {
                Console.WriteLine($"{jaartal} is geen schrikkeljaar");
                }
                
        }
    }
}
