using System;
using System.Linq;
using System.Collections.Generic;

namespace gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentNumber = numbers[i];
                int last = numbers[numbers.Count - 1 - i];

                int sum = currentNumber + last;

                numbers[i] = sum;
                result.Add(sum);
            }

            if (numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}