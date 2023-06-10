using System;
using System.Linq;
using System.Collections.Generic;

namespace changeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "Delete":
                        int numberToDelete = int.Parse(arguments[1]);
                        list = DeleteNumber(list, numberToDelete);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(arguments[1]);
                        int indexToInsertIn = int.Parse(arguments[2]);
                        list = InsertNumber(list, numberToInsert, indexToInsertIn);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static List<int> DeleteNumber(List<int> list, int numberToDelete)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == numberToDelete)
                {
                    list.Remove(numberToDelete);
                }
            }

            return list;
        }

        private static List<int> InsertNumber(List<int> list, int numberToInsert, int indexToInsertIn)
        {
            list.Insert(indexToInsertIn, numberToInsert);

            return list;
        }
    }
}