using System;
using System.Linq;

namespace calculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateArea(height, width));
        }

        static int CalculateArea(int height, int width)
        {
            int result = height * width;

            return result;
        }
    }
}