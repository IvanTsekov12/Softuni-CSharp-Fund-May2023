using System;
using System.Linq;
using System.Collections.Generic;

namespace vowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine(CountVowels(word));
        }

        static int CountVowels(string word)
        {
            int vowelsCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'o':
                    case 'u':
                    case 'i':
                    case 'e':
                    case 'A':
                    case 'O':
                    case 'U':
                    case 'I':
                    case 'E':
                        vowelsCount++;
                        break;
                }
            }

            return vowelsCount;
        }
    }
}