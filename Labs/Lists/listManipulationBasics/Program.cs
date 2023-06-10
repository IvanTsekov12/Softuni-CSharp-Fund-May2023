using System;
using System.Linq;
using System.Collections.Generic;

namespace listManipulationBasics
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); ;


            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(arguments[1]);
                        list.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(arguments[1]);
                        list.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(arguments[1]);
                        list.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(arguments[1]);
                        int index = int.Parse(arguments[2]);
                        list.Insert(index, numberToInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}