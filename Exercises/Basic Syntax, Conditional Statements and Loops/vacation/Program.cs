using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;
            double total = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.8;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.9;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.6;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.5;
                }
            }

            total = price * peopleCount;

            if (groupType == "Students" && peopleCount >= 30)
            {
                total *= 0.85;
            }
            else if (groupType == "Business" && peopleCount >= 100)
            {
                total -= 10 * peopleCount;
            }
            else if (groupType == "Regular" && (peopleCount >= 10 && peopleCount <= 20))
            {
                total *= 0.95;
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
