using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int biggestNum = 0;
            int midNum = 0;
            int lowestNum = 0;

            if (num1 >= num2 && num1 >= num3)
            {
                biggestNum = num1;
                if (num3 > num2)
                {
                    midNum = num3;
                    lowestNum = num2;
                }
                else if (num2 > num3)
                {
                    midNum = num2;
                    lowestNum = num3;
                }
                else if (num3 == num2)
                {
                    lowestNum = midNum = num3;
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                biggestNum = num2;
                if (num1 > num3)
                {
                    midNum = num1;
                    lowestNum = num3;
                }
                else if (num3 > num1)
                {
                    lowestNum = num1;
                    midNum = num3;
                }
                else if (num1 == num3)
                {
                    lowestNum = midNum = num3;
                }
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                biggestNum = num3;
                if (num1 > num2)
                {
                    midNum = num1;
                    lowestNum = num2;
                }
                else if (num2 > num1)
                { 
                    midNum = num2;
                    lowestNum = num1;
                }
                else if (num2 == num1)
                {
                    lowestNum = midNum = num1;
                }
            }

            Console.WriteLine(biggestNum);
            Console.WriteLine(midNum);
            Console.WriteLine(lowestNum);
        }
    }
}
