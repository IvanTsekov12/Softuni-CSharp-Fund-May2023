using System;
using System.Linq;
using System.Collections.Generic;

namespace students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentFields = Console.ReadLine().Split();
                string firstName = studentFields[0];
                string lastName = studentFields[1];
                decimal grade = decimal.Parse(studentFields[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);

                var sortedStudents = students.OrderByDescending(grade => grade.Grade);
                
                Console.WriteLine(string.Join("\n", sortedStudents));
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }

        public override string ToString()
        {
            string result = $"{FirstName} {LastName}:{Grade}"

            return result;
        }
    }
}