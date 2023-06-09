using System;
using System.Linq;
using System.Collections.Generic;

namespace listManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); ;

            List<int> startingList = new List<int>();
            foreach (int number in list)
            {
                startingList.Add(number);
            }
            int iterations = 0;
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                iterations++;
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "Contains":
                        int number = int.Parse(arguments[1]);
                        if (list.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        string evenResult = "";
                        foreach (int item in list)
                        {
                            if (item % 2 == 0)
                            {
                                evenResult += $"{item} ";
                            }
                        }
                        Console.WriteLine(evenResult.Trim());
                        break;
                    case "PrintOdd":
                        string oddResult = "";
                        foreach (int item in list)
                        {
                            if (item % 2 != 0)
                            {
                                oddResult += $"{item} ";
                            }
                        }
                        Console.WriteLine(oddResult.Trim());
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach (int item in list)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = arguments[1];
                        int numberCondition = int.Parse(arguments[2]);
                        string conditionaResult = "";
                        switch (condition)
                        {
                            case ">":
                                foreach (int item in list)
                                {
                                    if (item > numberCondition)
                                    {
                                        conditionaResult += $"{item} ";
                                    }
                                }

                                Console.WriteLine(conditionaResult.Trim());
                                break;
                            case "<":
                                foreach (int item in list)
                                {
                                    if (item < numberCondition)
                                    {
                                        conditionaResult += $"{item} ";
                                    }
                                }

                                Console.WriteLine(conditionaResult.Trim());
                                break;

                            case ">=":
                                foreach (int item in list)
                                {
                                    if (item >= numberCondition)
                                    {
                                        conditionaResult += $"{item} ";
                                    }
                                }

                                Console.WriteLine(conditionaResult.Trim());
                                break;
                            case "<=":
                                foreach (int item in list)
                                {
                                    if (item <= numberCondition)
                                    {
                                        conditionaResult += $"{item} ";
                                    }
                                }

                                Console.WriteLine(conditionaResult.Trim());
                                break;
                            default:
                                break;
                        }
                        break;
                }
            }
            if (iterations == 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}