using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] studentAtributes = command.Split();
                string firstName = studentAtributes[0];
                string lastName = studentAtributes[1];
                int age = int.Parse(studentAtributes[2]);
                string homeTown = studentAtributes[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                students.Add(student);
            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lasrName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lasrName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}