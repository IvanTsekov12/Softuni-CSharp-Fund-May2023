using System;
using System.Linq;
using System.Reflection;

namespace equalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = -1;

            for (int i = 0; i < array.Length; i++)
            {
                element = -1;
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += array[j];
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    element = i;
                    break;
                }
            }

            if (element != -1)
            {
                Console.WriteLine(element);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}