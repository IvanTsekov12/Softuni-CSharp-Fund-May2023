using System;
using System.Linq;
using System.Collections.Generic;

namespace softUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int hours = 0;
            int studentsAnswered = 0;
            int answersPerHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

            while (studentsCount > 0)
            {
                hours++;

                if (hours % 4 == 0)
                {
                    continue;
                }

                if (studentsCount >= answersPerHour)
                {
                    studentsCount -= answersPerHour;
                    studentsAnswered += answersPerHour;
                }
                else
                {
                    studentsCount = 0;
                    studentsAnswered += studentsCount;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}