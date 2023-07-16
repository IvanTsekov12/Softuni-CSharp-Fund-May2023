using System;
using System.Linq;
using System.Collections.Generic;

namespace heartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhood = Console.ReadLine().Split('@').Select(int.Parse).ToArray();

            string input = "";
            int cupidIndex = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                int length = int.Parse(input.Split(" ")[1]);
                cupidIndex += length;

                if (cupidIndex >= neighbourhood.Length)
                {
                    cupidIndex = 0;
                }

                neighbourhood[cupidIndex] -= 2;
                if (neighbourhood[cupidIndex] == 0)
                {
                    Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                }
                if (neighbourhood[cupidIndex] < 0)
                {
                    Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {cupidIndex}.");

            int fails = 0;
            for (int i = 0; i < neighbourhood.Length; i++)
            {
                if (neighbourhood[i] > 0)
                {
                    fails++;
                }
            }

            if (fails != 0)
            {
                Console.WriteLine($"Cupid has failed {fails} places.");
                return;
            }

            Console.WriteLine("Mission was successful.");
        }
    }
}