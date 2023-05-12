using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i < username.Length && i >= 0; i--)
            {
                char letter = username[i];
                password += letter;
            }

            string input = Console.ReadLine();
            int guessCounter = 0;

            while (true)
            {
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                guessCounter++;
                if (guessCounter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
               
            }
        }
    }
}
