    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;

    namespace muOnline
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int currentRoom = 0;
                int health = 100;
                int bitcoins = 0;

                string[] dungeonRooms = Console.ReadLine().Split('|').ToArray();

                foreach (string room in dungeonRooms)
                {
                    currentRoom++;
                    string[] roomTokens = room.Split(' ').ToArray();

                    string encounter = roomTokens[0];
                    int amount = int.Parse(roomTokens[1]);

                    if (encounter == "potion")
                    {
                        if (health + amount > 100)
                        {
                            Console.WriteLine($"You healed for {100 - health} hp.");
                            health = 100;
                        }
                        else
                        {
                            health += amount;
                            Console.WriteLine($"You healed for {amount} hp.");
                        }

                        Console.WriteLine($"Current health: {health} hp.");
                    continue;
                    }
                    if (encounter == "chest")
                    {
                        bitcoins += amount;
                        Console.WriteLine($"You found {amount} bitcoins.");
                        continue;
                    }

                    health -= amount;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {encounter}.");
                        Console.WriteLine($"Best room: {currentRoom}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {encounter}.");
                    }
                 
                
                
                }

                if (health > 0)
                {
                    Console.WriteLine("You've made it!");
                    Console.WriteLine($"Bitcoins: {bitcoins}");
                    Console.WriteLine($"Health: {health}");
                }
            }
        }
    }