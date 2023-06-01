using System;
using System.Collections.Generic;
using System.Linq;

namespace topIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isBigger = true;
            int element = 1;
            int result = 0;

            foreach (int number  in array)
            {
                for (int elementIndex = element; elementIndex < array.Length; elementIndex++)
                {
                    if (number > array[elementIndex])
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger || element == array.Length)
                {
                    Console.Write(number + " ");
                }

                element++;
            }
        }
    }
}