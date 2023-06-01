using System;
using System.Linq;

namespace zigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] array1 = new int[lines];
            int[] array2 = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < 1; j++)
                {
                    if (i % 2 == 0)
                    {
                        array1[i] = array[0];
                        array2[i] = array[1];

                    }
                    else
                    {
                        array2[i] = array[0];
                        array1[i] = array[1];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}