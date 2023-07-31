using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numsToAdd = int.Parse(tokens[1]);
                        nums.Add(numsToAdd);
                        break;
                    case "Remove":
                        int numsToRemove = int.Parse(tokens[1]);
                        nums.Remove(numsToRemove);
                        break;
                    case "RemoveAt":
                        int numsToRemoveAt = int.Parse(tokens[1]);
                        nums.RemoveAt(numsToRemoveAt);
                        break;
                    case "Insert":
                        int numsToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        nums.Insert(indexToInsert, numsToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
