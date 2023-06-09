using System;
using System.Linq;
using System.Collections.Generic;

namespace middleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(MiddleCharacters(text));
        }

        static string MiddleCharacters(string text)
        {

            string result = "";
            if (text.Length % 2 == 0)
            {
                result += text[text.Length / 2 - 1];
                result += text[(text.Length / 2)];
            }
            else
            {
                result += result += text[text.Length / 2];
            }

            return result;
        }
    }
}