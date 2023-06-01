using System;
using System.Linq;

namespace _09_greatreOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfInput = Console.ReadLine();

            if (typeOfInput == "int")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(number1, number2));
            }
            else if (typeOfInput == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();

                Console.WriteLine(GetMax(text1, text2));
            }
            else
            {
                char symbol1 = char.Parse(Console.ReadLine());
                char symbol2 = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(symbol1, symbol2));
            }
        }

        static int GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        static char GetMax(char symbol1, char symbol2)
        {
            if (symbol1 > symbol2)
            {
                return symbol1;
            }
            else
            {
                return symbol2;
            }
        }

        static string GetMax(string text1, string text2)
        {
            if (text1.Equals(text2))
            {
                return text1;
            }
            else
            {
                return text2;
            }
        }
    }
}