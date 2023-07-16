using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace softUniBarIncome
{
    class Order
    {
        /*
        public Order(string customer, string product, uint count, decimal price)
        {
            Customer = customer;
            Product = product;
            Count = count;
            Price = price;
        }
        */
        public string Customer { get; set; }
        public string Product { get; set; }
        public uint Count { get; set; }
        public decimal Price { get; set; }

        public decimal Total()
        {
            return Price * Count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<Customer>[A-Z][a-z]+)%[^|&$.]*<(?<Product>\w+)>[^|&$.]*\|(?<Quantity>\d+)\|[^|&$.]*?(?<Price>\d+\.\d+|\d+)\$";
            List<Order> orders = new List<Order>();

            string command = "";
            decimal total = 0;
            while ((command = Console.ReadLine()) != "end of shift")
            {
                foreach (Match match in Regex.Matches(command, pattern))
                {/*
                    string customer = match.Groups["Customer"].Value;
                    string product = match.Groups["Product"].Value;
                    uint count = uint.Parse(match.Groups["Quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["Price"].Value);
                    */
                    Order order = new Order();
                    order.Customer = match.Groups["Customer"].Value;
                    order.Product = match.Groups["Product"].Value; ;
                    order.Count = uint.Parse(match.Groups["Quantity"].Value);
                    order.Price = decimal.Parse(match.Groups["Price"].Value);
                    total += order.Total();

                    orders.Add(order);
                }
            }

            foreach (Order order in orders)
            {
                Console.WriteLine($"{order.Customer}: {order.Product} - {order.Total():f2}");
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}