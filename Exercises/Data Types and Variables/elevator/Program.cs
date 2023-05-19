using System;

namespace elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;

            while (people > 0)
            {
                courses++;
                Math.Abs(people -= capacity);
            }

            Console.WriteLine(courses);
        }
    }
}