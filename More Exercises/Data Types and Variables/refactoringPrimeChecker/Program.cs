using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currentNum = 2; currentNum <= number; currentNum++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor < currentNum; divisor++)
                {
                    if (currentNum % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}
