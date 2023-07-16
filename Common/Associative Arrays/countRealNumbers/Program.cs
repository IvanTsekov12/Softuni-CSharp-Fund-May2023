using System;
using System.Linq;
using System.Collections.Generic;

namespace countRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary[numbers[i]] = 1;
                }
                else
                {
                    dictionary[numbers[i]]++;
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }

        static void Method1()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary[numbers[i]] = 1;
                }
                else
                {
                    dictionary[numbers[i]]++;
                }
            }

            var sortedDict = dictionary.OrderBy(x => x.Key);

            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}