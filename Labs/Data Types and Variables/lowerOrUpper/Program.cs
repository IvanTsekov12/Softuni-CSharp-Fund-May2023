using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();

            if (symbol == symbol.ToLower())
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
