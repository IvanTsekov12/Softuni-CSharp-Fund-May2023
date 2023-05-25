using System;

namespace fromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                long leftNumber = long.Parse(numbers[0]);
                long rightNumber = long.Parse(numbers[1]);
                long sum = 0;

                if (leftNumber > rightNumber)
                {
                    while (Math.Abs(leftNumber) != 0)
                    {
                        sum += Math.Abs(leftNumber % 10);
                        Math.Abs(leftNumber /= 10);
                    }
                }
                else
                {
                    while (Math.Abs(rightNumber) != 0)
                    {
                        sum += Math.Abs(rightNumber % 10);
                        Math.Abs(rightNumber /= 10);
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}