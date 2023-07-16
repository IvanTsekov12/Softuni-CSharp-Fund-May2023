using System;
using System.Linq;
using System.Collections.Generic;   

namespace oddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string item in words)
            {
                string word = item.ToLower();
                word.ToLower();
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 1;
                }
                else
                {
                    wordCount[word]++;
                }
            }

            List<string> wordsToPrint = new List<string>();

            foreach (var kvp in wordCount)
            {
                if (kvp.Value % 2 != 0)
                {
                    wordsToPrint.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(" ", wordsToPrint));
        }
    }
}