using System;
using System.Linq;

namespace repeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            Console.WriteLine(Repeat(text, repeats));
        }

        static string Repeat(string text, int repeats)
        {
            string result = "";

            for (int i = 0; i < repeats; i++)
            {
                result += text;
            }

            return result;
        }
    }
}