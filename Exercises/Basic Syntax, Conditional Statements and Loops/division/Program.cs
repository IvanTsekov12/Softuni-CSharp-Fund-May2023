using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divisible = 0;

            if (num % 2 == 0)
            {
                divisible = 2;
            }
            if (num % 3 == 0)
            {
                divisible = 3;
            }
            if (num % 6 == 0)
            {
                divisible = 6;
            }
            if (num % 7 == 0)
            {
                divisible = 7;
            }
            if (num % 10 == 0)
            {
                divisible = 10;
            }
            if (num % 2 != 0 && num % 3 != 0 && num % 6 != 0 && num % 7 != 0 && num % 10 != 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine("The number is divisible by " + divisible);
            }
        }
    }
}
