using System;
using System.Linq;
using System.Collections.Generic;

namespace orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> namesAndPrices = new Dictionary<string, decimal>();
            Dictionary<string, int> namesAndQuantities = new Dictionary<string, int>();
            List<string> keys = new List<string>();

            string command = "";
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] arguments = command.Split();
                string name = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);
                if (!namesAndPrices.ContainsKey(name))
                {
                    namesAndPrices.Add(name, price);
                    namesAndQuantities.Add(name, quantity);
                    keys.Add(name);
                }
                else
                {
                    namesAndQuantities[name] += quantity;
                    namesAndPrices[name] = price;
                }
            }

            for (int i = 0; i < keys.Count; i++)
            {
                namesAndPrices[keys[i]] = namesAndPrices[keys[i]] * namesAndQuantities[keys[i]];
            }

            foreach (var kvp in namesAndPrices)
            {

                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}