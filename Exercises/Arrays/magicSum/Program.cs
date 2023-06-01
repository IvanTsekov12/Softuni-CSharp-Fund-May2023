using System;
using System.Linq;

namespace magicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            int index = 1;
            bool isEqual = true;

            /*for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + array[i + 1] == sum)
                {
                    Console.WriteLine(array[i] + " " + array[i + 1]);
                }
            }*/

            foreach (int number in array)
            {
                for (int i = index; i < array.Length; i++)
                {
                    if (number + array[i] == sum)
                    {
                        Console.WriteLine(number + " " + array[i]);
                    }
                }

                index++;
            }
        }
    }
}