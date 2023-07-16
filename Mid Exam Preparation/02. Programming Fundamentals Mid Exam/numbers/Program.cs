using System;
using System.Linq;
using System.Collections.Generic;

namespace numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            double listAverage = 0;

            for (int i = 0; i < list.Count; i++)
            {
                listAverage += list[i];
            }

            listAverage = listAverage / list.Count;

            int biggerNumsCount = 0;
            int index = 0;
            int originalListCount = list.Count;

            for (int i = 0; i < originalListCount; i++)
            {
                if (list[index] > listAverage)
                {
                    biggerNumsCount++;
                }
                else
                {
                    list.Remove(list[index]);
                    index--;
                }

                index++;
            }

            list.Sort();
            list.Reverse();

            if (biggerNumsCount > 0 && biggerNumsCount <= 5)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else if (biggerNumsCount > 5)
            {
                list.RemoveRange(5, list.Count - 5);
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}