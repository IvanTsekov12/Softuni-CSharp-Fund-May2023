using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "Add":
                        int passengersToAdd = int.Parse(arguments[1]);
                        wagons.Add(passengersToAdd);
                        break;
                    default:
                        int passengerToFill = int.Parse(arguments[0]);
                        for (int i = 0; i < wagons.Count; i++)
                        {
                            if (wagons[i] + passengerToFill <= wagonCapacity)
                            {
                                wagons[i] += passengerToFill;
                                break;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}