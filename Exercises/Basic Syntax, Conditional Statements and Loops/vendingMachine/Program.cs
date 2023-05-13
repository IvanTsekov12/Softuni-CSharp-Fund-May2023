using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalCoins = 0;

            while (true)
            {
               string command = Console.ReadLine();
                if (command == "Start")
                {
                    break;
                }
                double coin = double.Parse(command);

                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    continue;
                }
                totalCoins += coin;
            }

            while (true) 
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine($"Change: {totalCoins:f2}");
                    break;
                }

                if (command == "Nuts")
                {
                    if (totalCoins >= 2)
                    {
                        Console.WriteLine("Purchased nuts");
                        totalCoins -= 2;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Water")
                {
                    if (totalCoins >= 0.7)
                    {
                        Console.WriteLine("Purchased water");
                        totalCoins -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Crisps")
                {
                    if (totalCoins >= 1.5)
                    {
                        Console.WriteLine("Purchased crisps");
                        totalCoins -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Soda")
                {
                    if (totalCoins >= 0.8)
                    {
                        Console.WriteLine("Purchased soda");
                        totalCoins -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Coke")
                {
                    if (totalCoins >= 1)
                    {
                        Console.WriteLine("Purchased coke");
                        totalCoins -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
        }
    }
}
