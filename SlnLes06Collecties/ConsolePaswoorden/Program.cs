using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaswoorden
{
    internal class Program
    {
        static string[] passwords = { "klepketoe","test", "Azerty123", "rogier@work", "password", "MisterNasty12", "pwnz0red" };
        
        static void Main(string[] args)
        {
            string[] okPasswords = passwords.Where(IsCorrectPassword).ToArray();
            string[] notOkPasswords = passwords.Where(p => !IsCorrectPassword(p)).ToArray();

            Console.WriteLine(@"Alle paswoorden: 
1.klepketoe
2.test
3.Azerty123
4.rogier@work
5.password
6.MisterNasty12
7.pwnz0red
");

            Console.Write("OK: ");
            foreach (string password in okPasswords)
            {
                Console.Write($"{password},");
            }
            Console.WriteLine();
            Console.Write("Niet ok: ");
            foreach (string password in notOkPasswords)
            {
                Console.Write($"{password},");
            }
            Console.ReadLine();
        }

        static bool IsCorrectPassword(string password)
        {
            if (password.Length < 8) return false;
            if (password.Contains("@")) return false;
            if (password == "123456789" || password == "password" || password == "Azerty123") return false;

            return true;

        }
    }
}
