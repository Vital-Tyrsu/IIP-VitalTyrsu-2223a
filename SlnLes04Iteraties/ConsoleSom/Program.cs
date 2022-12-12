using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int som = 0;
            
            do
            {
                Console.Write("Voer een getal in (q om te stoppen): ");
                input = Convert.ToString(Console.ReadLine());
                if (input != "q")
                {
                   int getal = Convert.ToInt32(input);
                   som = som + getal;
                }
                

            } while (input != "q");
            Console.WriteLine("De som is: " + som);

            Console.ReadLine();
        }
    }
}
