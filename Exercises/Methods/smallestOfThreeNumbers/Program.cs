using System;
using System.Linq;
using System.Collections.Generic;

namespace smallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestOfThree(number1, number2, number3));
        }

        static int SmallestOfThree(int number1, int number2, int number3)
        {
            if (number1 < number2 && number1 < number3)
            {
                return number1;
            }
            else if (number2 < number1 && number2 < number3)
            {
                return number2;
            }
            else if (number3 < number2 && number3 < number1)
            {
                return number3;
            }
            else
            {
                return number1;
            }
        }
    }
}