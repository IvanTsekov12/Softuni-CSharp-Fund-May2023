using System;
using System.Linq;
using System.Collections.Generic;

namespace charactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", SymbolsInRange(symbol1, symbol2)));
        }

        static char[] SymbolsInRange(char symbol1, char symbol2)
        {
            if ((int)symbol2 < (int)symbol1)
            {
                char tmp = symbol2;
                symbol2 = symbol1;
                symbol1 = tmp;
            }

            int startIndex = (int)symbol1;
            int endIndex = (int)symbol2;

            char[] symbols = new char[(endIndex - startIndex) - 1];

            for (int i = startIndex + 1; i < endIndex; i++)
            {
                symbols[i - startIndex - 1] = (char)i;
            }

            return symbols;
        }
    }
}