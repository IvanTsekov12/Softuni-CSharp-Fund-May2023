using System;

namespace printNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersInArr = int.Parse(Console.ReadLine());
            int[] numbers = new int[numbersInArr];
            for (int i = 0; i < numbersInArr; i++) 
            {
                numbers[i] = int.Parse(Console.ReadLine()); ;
            }
            //METHOD 1
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[numbers.Length - i] + " ");
            }
            /*METHOD 2
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[numbers.Length - i - 1] + " ");
            }
            */
            /*METHOD 3
             for (int i = 1; i <= numbers.Length; i++)
            {
                Console.Write(numbers[numbers.Length - i] + " ");
            } 
             */
            /*METHOD 4
             numbers.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", numbers));
             */
        }
    }
}