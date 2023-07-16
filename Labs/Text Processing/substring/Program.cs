using System;
using System.Linq;
using System.Collections.Generic;

namespace substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                int indexOfWord = text.IndexOf(wordToRemove);
                if (indexOfWord != -1)
                {
                    text = text.Remove(indexOfWord, wordToRemove.Length);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(text);
        }
    }
}