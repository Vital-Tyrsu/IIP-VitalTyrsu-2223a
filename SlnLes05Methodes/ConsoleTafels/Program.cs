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

            Console.Write("Geef een getal: ");
            int getal1= Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef een getal: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            DrukTafel(getal1, getal2);
            Console.ReadLine();
        }

        static void DrukTafel(int get, int len)
        {
            
            for (int i = 1; i <= len; i++)
            {
                
                Console.WriteLine($"{get} x {len} = {get * len}" );
            }
            
        }
      
        
    } 
}

