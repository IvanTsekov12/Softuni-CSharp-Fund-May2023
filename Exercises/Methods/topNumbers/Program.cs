using System;
using System.Linq;

namespace topNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            if (IsDivisibleByEight(number) && HasOddNumber(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static bool HasOddNumber(int number)
        {
            bool isOdd = false;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }

        static bool IsDivisibleByEight(int number)
        {
            int digitsSum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                digitsSum += digit;
            }

            return digitsSum % 8 == 0;
        }
    }
}