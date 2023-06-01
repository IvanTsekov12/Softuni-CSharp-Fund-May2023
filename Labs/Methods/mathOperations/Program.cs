using System;
using System.Linq;

namespace mathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(number1, operation, number2));
        }

        static double Calculate(int number1, string operation, int number2)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "/":
                    result = (double)(number1 / number2);
                    break;
                case "*":
                    result = number1 * number2;
                    break;
            }

            return result;
        }
    }
}