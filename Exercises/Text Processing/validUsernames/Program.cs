using System;
using System.Linq;
using System.Collections.Generic;

namespace validUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] usernames = input.Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                bool isValidUsername = username.All(x => char.IsLetterOrDigit(x) || x == '-' || x == '_');

                if (isValidUsername)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}