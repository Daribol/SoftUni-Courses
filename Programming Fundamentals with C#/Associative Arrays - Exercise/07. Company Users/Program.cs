using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            var company = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                }

                if (!company.ContainsKey(employeeId))
                {
                    if (company[companyName].Contains(employeeId))
                    {
                        continue;
                    }
                    company[companyName].Add(employeeId);
                }
            }

            foreach (var kvp in company)
            {
                Console.WriteLine(kvp.Key);

                foreach (var employee in kvp.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
