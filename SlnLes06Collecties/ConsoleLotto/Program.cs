using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Vaste Array Trekking aanmaken
            int[] trekking = { 3, 5, 28, 16, 8, 31, 42 };

            // Array Poging aanmaken + overlopen
            int[] poging = new int[6];
            int lengte = poging.Length;

            Console.Write("Geef 6 getallen tussen 1 en 42 gescheiden door spaties: ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');

            for (int i = 0; i < inputArray.Length; i++)
            {
                poging[i] = Convert.ToInt32(inputArray[i]);
            }

            // Lege list Juist aanmaken
            List<int> juiste = new List<int>();
            int aantalJuist=0;
            for (int i = 0; i < poging.Length; i++)
            {
                if (trekking.Contains(poging[i]))
                {
                    juiste.Add(poging[i]);
                    aantalJuist++;
                }
                
            }
            
            Console.WriteLine("Trekking: " + String.Join(",", trekking));
            Console.WriteLine($"Je hebt {aantalJuist} juist : " + String.Join(", ", juiste));

            Console.ReadLine();


        }
    }
}
