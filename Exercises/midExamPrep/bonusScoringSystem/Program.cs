using System;
using System.Linq;
using System.Collections.Generic;

namespace bonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBounus = int.Parse(Console.ReadLine());

            decimal biggestBonus = 0;
            int maxAtendances = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int atendances = int.Parse(Console.ReadLine());
                decimal bonus = Math.Ceiling((decimal)atendances / lectures * (5 + additionalBounus));

                if (bonus > biggestBonus)
                {
                    biggestBonus = bonus;
                    maxAtendances = atendances;
                }
            }

            Console.WriteLine($"Max Bonus: {biggestBonus}.");
            Console.WriteLine($"The student has attended {maxAtendances} lectures.");
        }
    }
}