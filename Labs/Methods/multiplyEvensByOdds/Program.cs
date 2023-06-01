using System;
using System.Linq;

namespace multiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        static int GetSumOfEvenDigits(int number)
        {
            number = Math.Abs(number);
            string textNumber = number.ToString();
            int result = 0;

            for (int i = 0; i < textNumber.Length; i++)
            {
                int digit = number %  10;

                if (digit % 2 == 0)
                {
                    result += digit;
                }
                number /= 10;
            }

            return result;
        }

        static int GetSumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            string textNumber = number.ToString();
            int result = 0;

            for (int i = 0; i < textNumber.Length; i++)
            {
                int digit = number % 10;

                if (digit % 2 == 1)
                {
                    result += digit;
                }
                number /= 10;
            }

            return result;
        }
    }
}