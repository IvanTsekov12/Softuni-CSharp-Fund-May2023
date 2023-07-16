using System;
using System.Linq;
using System.Collections.Generic;

namespace bombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = specialNumbers[0];
            int radius = specialNumbers[1];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber)
                {
                    list.RemoveRange(i + 1, radius);
                    list.RemoveRange(i - radius, radius);
                    list.RemoveAt(i);
                }
            }

            int sum = 0;

            foreach (int item in list)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}