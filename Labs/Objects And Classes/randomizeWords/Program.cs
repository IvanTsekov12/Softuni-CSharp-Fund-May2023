using System;
using System.Linq;
using System.Collections.Generic;

namespace randomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                string vauleAtIndex = input[i];
                int randomIndex = random.Next(0, input.Length);
                string randomValueAtIndex = input[randomIndex];
                input[i] = randomValueAtIndex;
                input[randomIndex] = vauleAtIndex;
            }

            foreach (string value in input)
            {
                Console.WriteLine(value);
            }
        }
    }
}
