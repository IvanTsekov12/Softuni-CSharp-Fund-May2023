using System;
using System.Linq;
using System.Collections.Generic;

namespace countCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    if (!dictionary.ContainsKey(text[i]))
                    {
                        dictionary[text[i]] = 1;
                    }
                    else
                    {
                        dictionary[text[i]]++;
                    }
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}