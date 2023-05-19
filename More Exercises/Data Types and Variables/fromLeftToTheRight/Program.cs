using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    while (leftNumber > 0)
                    {
                        sum += leftNumber % 10;
                        leftNumber /= 10;
                    }
                }
                else
                {
                    while (rightNumber > 0)
                    {
                        sum += rightNumber % 10;
                        rightNumber /= 10;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
