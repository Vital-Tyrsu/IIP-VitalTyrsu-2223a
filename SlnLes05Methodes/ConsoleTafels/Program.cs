using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleTafels
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int getal1;
                int lengte1;

                Console.Write("Geef een getal: ");
                getal1 = Convert.ToInt32(Console.ReadLine());
                if (getal1 < 0)
                {
                    VraagPositiefGetal(getal1);
                }
                else
                {
                    Console.Write("Geef een lengte: ");
                    lengte1 = Convert.ToInt32(Console.ReadLine());
                    DrukTafel(getal1, lengte1);
                }
                
            }
            Console.ReadLine();
        }

        static void DrukTafel(int getal1, int getal2)
        {  
            for (int i = 1; i <= getal2; i++)
            {
                Console.WriteLine($"{getal1} x {getal2} = {i * getal1}");
            }    
        }

        static void VraagPositiefGetal(int getal1)
        {
            if (getal1 < 0)
            {
                Console.WriteLine("Getal moet positief zijn!");
                return;
            } 
        }
    } 
}

