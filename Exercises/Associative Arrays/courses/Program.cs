using System;
using System.Linq;
using System.Collections.Generic;

namespace courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            Dictionary<string, int> usersCount = new Dictionary<string, int>();
            List<string> keys = new List<string>();


            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(" : ");
                string courseName = arguments[0];
                string studentName = arguments[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>() { studentName });
                    usersCount.Add(courseName, 1);
                    keys.Add(courseName);
                    
                }
                else
                {
                    courses[courseName].Add(studentName);
                    usersCount[courseName] += 1;
                }
            }

            foreach (var kvp in usersCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                foreach (var kvp2 in courses)
                {
                    foreach (string user in kvp2.Value)
                    {
                        if (kvp2.Key == kvp.Key)
                        {
                            Console.WriteLine($"-- {user}");
                        }
                    }
                }

            }
        }
    }
}