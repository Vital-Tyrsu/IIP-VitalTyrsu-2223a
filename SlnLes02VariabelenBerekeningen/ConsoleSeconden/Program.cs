using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeconden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het aantal seconden: ");
            int seconden = Convert.ToInt32(Console.ReadLine());

            int dagen = seconden / (24 * 60 * 60);
            int restseconden = seconden % (24 * 60 * 60);

            int uren = restseconden / (60 * 60);
            restseconden = restseconden % (60 * 60);

            int minuten = restseconden / 60;
            restseconden = restseconden % 60;

            int seconds = restseconden;

            Console.WriteLine($"Dit zijn {dagen} en {uren} en {minuten} en {seconds}");
            Console.ReadLine();
        }
    }
}
