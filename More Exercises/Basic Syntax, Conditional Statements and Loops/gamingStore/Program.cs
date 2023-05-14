using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double totalSpent = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${budget:f2}");
                    break;
                }

                switch (command)
                {
                    case "OutFall 4":
                        if (budget >= 39.99)
                        {
                            totalSpent += 39.99;
                            budget -= 39.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (budget >= 15.99)
                        {
                            totalSpent += 15.99;
                            budget -= 15.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (budget >= 19.99)
                        {
                            totalSpent += 19.99;
                            budget -= 19.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (budget >= 59.99)
                        {
                            totalSpent += 59.99;
                            budget -= 59.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (budget >= 29.99)
                        {
                            totalSpent += 29.99;
                            budget -= 29.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (budget >= 39.99)
                        {
                            totalSpent += 39.99;
                            budget -= 39.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }
}
