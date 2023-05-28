using System;
using System.Linq;

namespace maxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(" ");
            int bestCount = 0;
            string bestSymol = "";
            for (int i = 0; i < elements.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i] == elements[j])
                    {
                        count++;
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestSymol = elements[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i <= bestCount; i++)
            {
                Console.Write(bestSymol + " ");
            }
        }
    }
}