using System;
using System.Linq;
using System.Collections.Generic;

namespace companyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();


            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                if (!employees.ContainsKey(companyName))
                {
                    employees.Add(companyName, new List<string>() {employeeId});
                }
                else
                {
                    if (!employees[companyName].Contains(employeeId))
                    {
                        employees[companyName].Add(employeeId);
                    }
                }
            }

            foreach (var kvp in employees)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (string employeeId in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}