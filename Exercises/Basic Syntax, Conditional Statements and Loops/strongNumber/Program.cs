using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumber = Console.ReadLine();
            int number = int.Parse(stringNumber);
            int sum = 1;

            for (int i = 0; i < stringNumber.Length; i++)
            {
                string stringDigit = stringNumber[i].ToString();
                int digit = int.Parse(stringDigit);
                for (int j = 1; j <= digit; j++)
                {
                    sum *= j;
                }
            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
