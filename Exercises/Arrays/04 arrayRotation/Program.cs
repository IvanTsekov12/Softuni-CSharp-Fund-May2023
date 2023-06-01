using System;
using System.Linq;

namespace _04_arrayRotation
{
    /*
     51 47 32 61 21
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int tmp = array[0];
                int j = 0;

                while (j + 1 != array.Length)
                {
                    array[j] = array[j + 1];
                    j++;
                }

                array[array.Length - 1] = tmp;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}