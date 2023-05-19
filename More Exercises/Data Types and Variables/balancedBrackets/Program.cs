using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            bool isBalanced = false;

            int openingCount = 0;
            int closingCount = 0;

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
                }

                if (closingCount > openingCount)
                {
                    isBalanced = false;
                }
                else if(openingCount > closingCount)
                {
                    isBalanced = false;
                }
                else if (openingCount == closingCount)
                {
                    isBalanced = true;
                    openingCount = 0;
                    closingCount = 0;
                }
            }

            if (isBalanced)
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
