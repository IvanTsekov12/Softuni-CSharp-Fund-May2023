using System;

namespace dayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());

            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            if (index <= 0 || index >= 8)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[index - 1]);
            }
        }
    }
}