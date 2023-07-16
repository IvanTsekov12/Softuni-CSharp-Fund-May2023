using System;
using System.Linq;
using System.Collections.Generic;

namespace computerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPriceNoTax = 0;
            bool isSpecial = false;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "special" || input == "regular")
                {
                    if (input == "special")
                    {
                        isSpecial = true;
                    }
                    break;
                }

                double currentPrice = double.Parse(input);
                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                totalPriceNoTax += currentPrice;
            }

            if (totalPriceNoTax == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            double tax = totalPriceNoTax * 0.2;

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceNoTax:F2}$");
            Console.WriteLine($"Taxes: {tax:F2}$");
            Console.WriteLine("-----------");

            double totalPrice = tax + totalPriceNoTax;
            if (isSpecial)
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}$");
        }
    }
}