using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFaculteit
{
    internal class Program
    {
        static private int Faculteit(int nummer)
        {
            int faculteit = 1;
            for (int i = nummer; i >= 1; i--)
            {
                faculteit = faculteit * i;
            }
            return faculteit;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("FACULTEIT BEREKENEN");
            Console.Write("Geef een geheel getal:");
            int getal = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"De faculteit is {Faculteit(getal)}.");
            Console.ReadLine();
        }
    }
}


