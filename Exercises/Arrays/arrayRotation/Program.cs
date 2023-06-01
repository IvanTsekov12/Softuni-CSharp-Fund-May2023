using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace arrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                array[array.Length + i] = array[i];
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}