using System;
using System.Linq;
using System.Collections.Generic;

namespace treasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split('|').ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "Loot":
                        for (int i = 1; i < arguments.Length; i++)
                        {
                            string item = arguments[i];

                            if (!chest.Contains(item))
                            {
                                chest.Insert(0, item);
                            }
                        }
                        break;
                    case "Drop":
                        int index = int.Parse(arguments[1]);
                        if (index >= 0 && index < chest.Count)
                        {
                            string droppedItem = chest[index];
                            chest.RemoveAt(index);
                            chest.Add(droppedItem);
                        }
                        break;
                    case "Steal":
                        int stolenItemsCount = int.Parse(arguments[1]);
                        int startingIndex = chest.Count - stolenItemsCount;
                        List<string> stolenItems = new List<string>();
                        if (stolenItemsCount < chest.Count)
                        {
                            stolenItems.AddRange(chest.GetRange(startingIndex, stolenItemsCount));
                            chest.RemoveRange(startingIndex, stolenItemsCount);
                        }
                        else
                        {
                            stolenItems = chest;
                        }
                        Console.WriteLine(string.Join(", ", stolenItems));
                        if (stolenItemsCount >= chest.Count)
                        {
                            chest.Clear();
                        }
                        break;
                }
            }

            double finalSum = 0;

            for (int i = 0; i < chest.Count; i++)
            {
                finalSum += chest[i].Length;
            }

            if (chest.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {(finalSum / chest.Count):f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}