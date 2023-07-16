using System;
using System.Linq;
using System.Collections.Generic;

namespace aMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string command = "";
            int iterations = 0;
            while ((command = Console.ReadLine()) != "stop")
            {
                iterations++;
                string toAdd = "";
                toAdd = toAdd + " " + command;

                if (iterations % 2 == 0)
                {
                    string[] arguments = toAdd.Split(" ");
                    toAdd = "";
                    dict.Add(arguments[0], int.Parse(arguments[1]));
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}