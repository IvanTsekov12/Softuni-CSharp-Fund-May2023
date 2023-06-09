using System;
using System.Linq;
using System.Collections.Generic;

namespace addAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(AddAndSubtract(number1, number2, number3));
        }

        static int AddAndSubtract(int number1, int number2, int number3)
        {
            int addResult = number1 + number2;
            int subtractResult = addResult - number3;

            return subtractResult;
        }
    }
}