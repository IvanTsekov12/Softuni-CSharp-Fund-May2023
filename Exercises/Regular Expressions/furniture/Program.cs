using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class Furniture
{
    public Furniture(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal Total()
    {
        return Price * Quantity;
    }
}

namespace furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();

            string pattern = @">>(?<Name>[A-Za-z]+)<<(?<Price>\d+\.\d+|\d+)\!(?<Quantity>\d+)";

            string command = "";
            while ((command = Console.ReadLine()) != "Purchase")
            {
                Regex r = new Regex(pattern);
                MatchCollection collection = r.Matches(command);
                
                foreach (Match match in collection)
                {
                    string name = match.Groups["Name"].Value;
                    decimal price = decimal.Parse(match.Groups["Price"].Value);
                    int quantity = int.Parse(match.Groups["Quantity"].Value);

                    Furniture furniture = new Furniture(name, price, quantity);
                    furnitures.Add(furniture);
                }
            }

            Console.WriteLine("Bought furniture:");
            decimal total = 0;
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                total += furniture.Total();
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}