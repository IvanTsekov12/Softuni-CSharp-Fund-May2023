using System;
using System.Linq;

namespace encryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string[] array = new string[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                string word = Console.ReadLine();
                array[i] = word;
            }

            int[] encryptedWords = new int[numberOfLines];
            int j = 0;

            
            foreach (string word in array)
            {
                int wordSum;
                int sumOfVowels = 0;
                int sumOfConsonant = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    switch (word[i])
                    {
                        case 'a':
                        case 'A':
                        case 'o':
                        case 'O':
                        case 'U':
                        case 'u':
                        case 'i':
                        case 'I':
                        case 'E':
                        case 'e':
                            sumOfVowels += (int)word[i] * word.Length;
                            break;
                        default:
                            sumOfConsonant += (int)word[i] / word.Length;
                            break;
                    }
                }

                wordSum = sumOfConsonant + sumOfVowels;
                encryptedWords[j] = wordSum;
                j++;
            }

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int k = i + 1; k < numberOfLines; k++)
                {
                    if (encryptedWords[i] > encryptedWords[k])
                    {
                        int tmp = encryptedWords[k];
                        encryptedWords[k] = encryptedWords[i];
                        encryptedWords[i] = tmp;
                    }
                }
            }

            foreach (int sum in encryptedWords)
            {
                Console.WriteLine(sum);
            }

        }
    }
}