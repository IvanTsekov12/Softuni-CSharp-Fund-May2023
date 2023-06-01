using System;
using System.Linq;

namespace calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (action == "add")
            {
                Add(number1, number2);
            }
            else if (action == "multiply")
            {
               Multiply(number1, number2); 
            }
            else if (action == "subtract")
            {
                 Subtract(number1, number2);
            }
            else
            {
                Divide(number1, number2);
            }
        }

        static void Subtract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }

        static void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        static void Divide(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }
    }
}