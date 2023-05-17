using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poundToUSD
{
    internal class Program
    {
        static void Main(string[] args)
        {
        double num = double.Parse(Console.ReadLine());
        double result = num * 1.31;
        Console.WriteLine($"{result:f3}");
        }
    }
}
