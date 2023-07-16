using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_aMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string command = "";
            int iterations = 0;
            string toAdd = "";
            while ((command = Console.ReadLine()) != "stop")
            {
                iterations++;
                toAdd += command + " ";

                if (iterations % 2 == 0)
                {
                    toAdd.Trim();
                    string[] arguments = toAdd.Split(" ");
                    toAdd = "";
                    if (dict.ContainsKey(arguments[0]))
                    {
                        dict[arguments[0]] += int.Parse(arguments[1]);
                    }
                    else
                    {
                        dict.Add(arguments[0], int.Parse(arguments[1]));
                    }
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}