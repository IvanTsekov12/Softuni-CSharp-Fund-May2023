using System;
using System.Linq;
using System.Collections.Generic;

namespace manOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateship = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            int maxSectionHealth = int.Parse(Console.ReadLine());

            string command = "";

            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] argumnets = command.Split();

                switch (argumnets[0])
                {
                    case "Fire":
                        int attackIndex = int.Parse(argumnets[1]);
                        int attackedDamage = int.Parse(argumnets[2]);

                        if (attackIndex >= 0 && attackIndex < warship.Count)
                        {
                            warship[attackIndex] -= attackedDamage;
                            if (warship[attackIndex] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Defend":
                        int startIndex = int.Parse(argumnets[1]);
                        int endIndex = int.Parse(argumnets[2]);
                        int defendDamage = int.Parse(argumnets[3]);

                        if ((startIndex >= 0 && startIndex < pirateship.Count) && (endIndex >= 0 && endIndex < pirateship.Count))
                        {
                            bool isSunken = false;
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                pirateship[i] -= defendDamage;

                                if (pirateship[i] <= 0)
                                {
                                    isSunken = true;
                                }
                            }

                            if (isSunken)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Repair":
                        int indexToRepair = int.Parse(argumnets[1]);
                        int healthToAdd = int.Parse(argumnets[2]);
                        if (indexToRepair >= 0 && indexToRepair < pirateship.Count)
                        {
                            if (pirateship[indexToRepair] + healthToAdd <= maxSectionHealth)
                            {
                                pirateship[indexToRepair] += healthToAdd;
                            }
                            else
                            {
                                pirateship[indexToRepair] += maxSectionHealth - pirateship[indexToRepair];
                            }
                        }
                        break;
                    case "Status":
                        int sectionsToRepair = 0;
                        double criticalState = 0.2 * maxSectionHealth;

                        foreach (int section in pirateship)
                        {
                            if (section < criticalState)
                            {
                                sectionsToRepair++;
                            }
                        }

                        Console.WriteLine($"{sectionsToRepair} sections need repair.");
                        break;
                }
            }

            int piratshipStatus = 0;
            int warshipStatus = 0;

            foreach (int section in pirateship)
            {
                piratshipStatus += section;
            }
            foreach (int section in warship)
            {
                warshipStatus += section;
            }

            Console.WriteLine($"Pirate ship status: {piratshipStatus}");
            Console.WriteLine($"Warship status: {warshipStatus}");
        }
    }
}