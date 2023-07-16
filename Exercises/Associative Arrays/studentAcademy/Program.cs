using System;
using System.Linq;
using System.Collections.Generic;

namespace studentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!grades.ContainsKey(studentName))
                {
                    grades.Add(studentName, new List<double>() { grade });
                }
                else
                {
                    grades[studentName].Add(grade);
                }
            }

            foreach (var kvp in grades)
            {
                if (kvp.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
                }
            }
        }
    }
}