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

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == specialNumbers[0])
                {
                    list.RemoveRange(i, specialNumbers[1] + 1);
                    list.RemoveRange(i - specialNumbers[1],  specialNumbers[1]);
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