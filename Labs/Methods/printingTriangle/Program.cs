using System;
using System.Linq;

namespace printingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        static void PrintTriangle(int number)
        {
            PrintTopTrianglePart(number);
            PrintBottomTrianglePart(number - 1);
        }

        static void PrintTopTrianglePart(int number)
        {
            for (int rows = 1; rows <= number; rows++)
            {
                PrintTriangleRow(rows);
            }
        }

        static void PrintBottomTrianglePart(int number)
        {
            for (int rows = number; rows >= 1; rows--)
            {
                PrintTriangleRow(rows);
            }
        }

        static void PrintTriangleRow(int number)
        {
            for (int col = 1; col <= number; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }
    }
}