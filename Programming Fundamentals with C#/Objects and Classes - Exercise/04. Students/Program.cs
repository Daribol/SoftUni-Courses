using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _04._Students
{
    internal class Program
    {
        class Student
        {
            public Student(string firstName, string lastName, float grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public float Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade}";
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] newStudent = Console.ReadLine().Split().ToArray();

                string firstName = newStudent[0];
                string lastName = newStudent[1];
                string gradeWord = newStudent[2];
                float grade = float.Parse(gradeWord);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students.Sort((s1, s2) => s2.Grade.CompareTo(s1.Grade));

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
