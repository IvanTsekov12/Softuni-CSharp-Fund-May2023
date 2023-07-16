using System;
using System.Linq;
using System.Collections.Generic;

namespace shoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split('!').ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "Urgent":
                        string urgentItem = arguments[1];
                        if (!groceries.Contains(urgentItem))
                        {
                            groceries.Insert(0, urgentItem);
                        }
                        break;
                    case "Unnecessary":
                        string unnecessaryItem = arguments[1];
                        if (groceries.Contains(unnecessaryItem))
                        {
                            groceries.Remove(unnecessaryItem);
                        }
                        break;
                    case "Correct":
                        string oldItem = arguments[1];
                        string newItem = arguments[2];
                        if (groceries.Contains(oldItem))
                        {
                            int oldItemIndex = groceries.IndexOf(oldItem);
                            groceries[oldItemIndex] = newItem;
                        }
                        break;
                    case "Rearrange":
                        string item = arguments[1];
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                            groceries.Add(item);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}