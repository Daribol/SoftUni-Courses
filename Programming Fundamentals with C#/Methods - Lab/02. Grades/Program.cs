using System;

namespace _02._Grades
{
    internal class Program
    {
        static void PrintInWords(double grade)
        {
            string gradeInWords = string.Empty;
            if (grade >= 2 && grade < 3)
            {
                gradeInWords = "Fail";
            }
            else if (grade >= 3 && grade < 3.50)
            {
                gradeInWords = "Poor";
            }
            else if (grade >= 3.50 && grade < 4.50)
            {
                gradeInWords = "Good";
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                gradeInWords = "Very good";
            }
            else if(grade >= 5.50 && grade <= 6)
            {
                gradeInWords = "Excellent";
            }
            Console.WriteLine(gradeInWords);
        }
        static void Main(string[] args)
        {
            PrintInWords(double.Parse(Console.ReadLine()));
        }
    }
}
