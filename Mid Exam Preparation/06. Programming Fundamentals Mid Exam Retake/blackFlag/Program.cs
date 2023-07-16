using System;
using System.Linq;
using System.Collections.Generic;

namespace blackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plunderingDays = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int day = 1; day <= plunderingDays; day++)
            {
                totalPlunder += dailyPlunder;
                if (day % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.5;
                }
                if (day % 5 == 0)
                {
                    totalPlunder -= 0.3 * totalPlunder;
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double collectedPlunderPercentage = (totalPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {collectedPlunderPercentage:f2}% of the plunder.");
            }
        }
    }
}