﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grade);
            }

            foreach (var kvp in students)
            {
                if (kvp.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
                }
            }
        }
    }
}
