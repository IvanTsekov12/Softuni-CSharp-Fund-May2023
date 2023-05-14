using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reversedText = "";

            for (int i = text.Length - 1; i < text.Length && i >= 0; i--)
            {
                char letter = text[i];
                reversedText += letter;
            }
            Console.WriteLine(reversedText);
        }
    }
}
