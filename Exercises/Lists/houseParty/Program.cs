using System;
using System.Linq;
using System.Collections.Generic;

namespace houseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandLines = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < commandLines; i++)
            {
                string command = Console.ReadLine();
                string[] commandArr = command.Split();
                string name = commandArr[0];
                string action = command.Substring(name.Length + 1);

                if (action == "is going!")
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (action == "is not going!")
                {
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(name);
                    }
                }
            }

            foreach (string name in guests)
            {
                Console.WriteLine(name);
            }
        }
    }
}