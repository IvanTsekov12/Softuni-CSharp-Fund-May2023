using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charsToStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            char symbol3 = char.Parse(Console.ReadLine());

            string concatenateChars = "";
            concatenateChars += symbol1;
            concatenateChars += symbol2;
            concatenateChars += symbol3;

            Console.WriteLine(concatenateChars);
        }
    }
}
