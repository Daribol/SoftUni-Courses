using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[2] == "going!")
                {
                    if (names.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(command[0]);
                    }
                }
                else if (command[2] == "not")
                {
                    if (names.Contains(command[0]))
                    {
                        names.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
