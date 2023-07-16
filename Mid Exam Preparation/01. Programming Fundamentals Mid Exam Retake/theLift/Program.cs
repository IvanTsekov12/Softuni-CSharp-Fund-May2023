using System;
using System.Linq;
using System.Collections.Generic;

namespace theLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInQueue = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int subtract = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] < 4)
                {
                    if (peopleInQueue >= 4)
                    {
                        subtract = 4 - wagons[i];
                        wagons[i] += subtract;
                        peopleInQueue -= subtract;
                    }
                    else
                    {
                        wagons[i] += peopleInQueue;
                        peopleInQueue = 0;
                    }
                }
            }

            bool hasFreeSapces = false;

            foreach (int peopleInWagon in wagons)
            {
                if (peopleInWagon < 4)
                {
                    hasFreeSapces = true;
                }
            }

            if (hasFreeSapces && peopleInQueue <= 0)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (!hasFreeSapces && peopleInQueue > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleInQueue} people in a queue!");
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}