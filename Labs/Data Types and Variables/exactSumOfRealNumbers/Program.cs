using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < lines; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            

            Console.WriteLine(sum);
        }
    }
}
