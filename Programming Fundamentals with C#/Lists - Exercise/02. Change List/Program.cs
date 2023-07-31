using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                if (tokens[0] == "Delete")
                {
                    int deletedItems = int.Parse(tokens[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == deletedItems)
                        {
                            list.RemoveAt(i);
                        }
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    int insertedElement = int.Parse(tokens[1]);
                    int insertedPosition = int.Parse(tokens[2]);
                    list.Insert(insertedPosition, insertedElement);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
