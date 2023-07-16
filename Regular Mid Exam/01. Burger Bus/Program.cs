using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Burger_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());

            double totalProfit = 0;
            for (int currentCityCount = 1; currentCityCount <= numberOfCities; currentCityCount++)
            {
                string cityName = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());

                if (currentCityCount % 3 == 0 && currentCityCount % 5 != 0)
                {
                    expenses *= 1.5;
                }
                if (currentCityCount % 5 == 0)
                {
                    income *= 0.9;
                }
                double currentCityProfit = 0;
                currentCityProfit = income - expenses;
                totalProfit += currentCityProfit;

                Console.WriteLine($"In {cityName} Burger Bus earned {currentCityProfit:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}