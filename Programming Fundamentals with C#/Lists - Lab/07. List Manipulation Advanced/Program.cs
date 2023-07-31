using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
                    case "Conains":
                        int numsToContains = int.Parse(tokens[1]);
                        nums.Contains(numsToContains);
                        if (nums.Contains(numsToContains))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 == 0)
                            {
                                Console.Write(nums[i]);
                            }
                        }

                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 != 0)
                            {
                                Console.Write(nums[i]);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        nums.Sum();
                        break;
                    case "Filter":
                        char cond = char.Parse(tokens[1]);
                        int numToCond = int.Parse(tokens[2]);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
