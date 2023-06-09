using System;
using System.Linq;

namespace nXNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Matrix(number));
        }

        static string Matrix(int number)
        {
            string result = "";

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    result += $"{number} ";
                }

                result += "\n";
            }

            return result;
        }
    }
}