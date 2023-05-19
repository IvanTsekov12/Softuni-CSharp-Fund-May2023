using System;

namespace balancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int openingCount = 0;
            int closingCount = 0;
            bool isBalanced = false;
            for (int i = 0; i < lines; i++)
            {
                string textOrBracket = Console.ReadLine();

                if (textOrBracket == "(")
                {
                    openingCount++;
                }
                else if (textOrBracket == ")")
                {
                    closingCount++;
                    if (closingCount > openingCount)
                    {
                        isBalanced = false;
                    }
                    else if (closingCount == openingCount)
                    {
                        isBalanced = true;
                    }
                    else if (openingCount > closingCount && closingCount > 0)
                    {
                        isBalanced = false;
                    }

                }

                if (isBalanced)
                {
                    openingCount = 0;
                    closingCount = 0;
                    isBalanced = false;
                }
            }

            if (openingCount == 0 && closingCount == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}