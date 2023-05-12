using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toMultiply = int.Parse(Console.ReadLine());
            int multiplyer = int.Parse(Console.ReadLine());
            if (multiplyer > 10)
            {
                Console.WriteLine($"{toMultiply} X {multiplyer} = {toMultiply * multiplyer}");
            }
            else
            {
                for (int i = multiplyer; i <= 10; i++)
                {
                    Console.WriteLine($"{toMultiply} X {i} = {toMultiply * i}");
                }
            }
        }
    }
}
