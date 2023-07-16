using System;
using System.Linq;
using System.Collections.Generic;

namespace мemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            int guessesCount = 0;
            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                if (list.Count <= 0)
                {
                    Console.WriteLine($"You have won in {guessesCount} turns!");
                    break;
                }
                guessesCount++;
                
                int[] indexes = command.Split(' ').Select(int.Parse).ToArray();

                if (((indexes[0] >= 0 && indexes[0] < list.Count) && (indexes[1] >= 0 && indexes[1] < list.Count)) && indexes[0] != indexes[1])
                {
                    if (list[indexes[0]] == list[indexes[1]])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {list[indexes[0]]}!");
                        if (indexes[0] > indexes[1])
                        {
                            list.RemoveAt(indexes[0]);
                            list.RemoveAt(indexes[1]);
                        }
                        else
                        {
                            list.RemoveAt(indexes[1]);
                            list.RemoveAt(indexes[0]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    string toInsert = "-" + guessesCount + "a";
                    list.Insert(list.Count / 2, toInsert);
                    list.Insert(list.Count / 2, toInsert);
                }
            }

            if (list.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}