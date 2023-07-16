using System;
using System.Linq;
using System.Collections.Generic;

namespace arrayModifier
{
    /*
     "swap {index1} {index2}" takes two elements and swap their places.
     "multiply {index1} {index2}" takes element at the 1st index and multiply it with the element at 2nd index. Save the product at the 1st index.
     "decrease" decreases all elements in the array with 1
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int index1 = 0, index2 = 0;
                switch (arguments[0])
                {
                    case "swap":
                        index1 = int.Parse(arguments[1]);
                        index2 = int.Parse(arguments[2]);

                        int swap = list[index1];
                        list[index1] = list[index2];
                        list[index2] = swap;

                        break;
                    case "multiply":
                        index1 = int.Parse(arguments[1]);
                        index2 = int.Parse(arguments[2]);

                        list[index1] = list[index1] * list[index2];

                        break;
                    case "decrease":
                        for (int i = 0; i < list.Count; i++)
                        {
                            list[i]--;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}