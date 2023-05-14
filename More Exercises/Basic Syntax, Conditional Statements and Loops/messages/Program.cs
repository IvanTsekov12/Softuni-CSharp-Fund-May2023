using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lettersCount = int.Parse(Console.ReadLine());
            int offset = 0;
            int digitsCount = 0;
            string word = "";

            for (int i = 1; i <= lettersCount; i++)
            {
                string input = Console.ReadLine();
                digitsCount = input.Length;
                int mainDigit = int.Parse(input) % 10;
                offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + digitsCount - 1;
                if (input == "0")
                {
                    word += " ";
                }
                else
                {
                    word += (char)(letterIndex + 97);
                }
            }
            Console.WriteLine(word);
        }
    }
}
