using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCsv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] playerNames = { "Zakaria", "Saleha", "Indra", "Ralph", "Francisco", "Marie" };
            string[] gameTypes = { "chess", "checkers", "backgammon" };
            Random rnd = new Random();

            using (StreamWriter writer = new StreamWriter("matches.csv"))
            {
                for (int i = 0; i < 100; i++)
                {
                    string player1 = playerNames[rnd.Next(playerNames.Length)];
                    string player2 = playerNames[rnd.Next(playerNames.Length)];

                    for (int j = 0; j < 3; j++)
                    {
                        string gameType = gameTypes[rnd.Next(gameTypes.Length)];
                        int player1Score = rnd.Next(3) + 1; // geeft een willekeurige score van speler1
                        int player2Score = rnd.Next(3) + 1; // geeft idem als boven maar voor speler2
                        string score = $"{player1Score}-{player2Score}";

                        writer.WriteLine($"{player1};{player2};{gameType};{score}");
                    }
                }
            }
        }
    }
}
