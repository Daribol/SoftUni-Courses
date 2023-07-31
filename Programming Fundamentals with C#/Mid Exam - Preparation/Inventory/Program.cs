using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> inventory = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] commandParts = command.Split(" - ");

                if (commandParts[0] == "Collect")
                {
                    string item = commandParts[1];
                    CollectItem(inventory, item);
                }
                else if (commandParts[0] == "Drop")
                {
                    string item = commandParts[1];
                    DropItem(inventory, item);
                }
                else if (commandParts[0] == "Combine Items")
                {
                    string[] items = commandParts[1].Split(':');
                    string oldItem = items[0];
                    string newItem = items[1];
                    CombineItems(inventory, oldItem, newItem);
                }
                else if (commandParts[0] == "Renew")
                {
                    string item = commandParts[1];
                    RenewItem(inventory, item);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }

        static void CollectItem(List<string> inventory, string item)
        {
            if (!inventory.Contains(item))
            {
                inventory.Add(item);
            }
        }

        static void DropItem(List<string> inventory, string item)
        {
            if (inventory.Contains(item))
            {
                inventory.Remove(item);
            }
        }

        static void CombineItems(List<string> inventory, string oldItem, string newItem)
        {
            int index = inventory.IndexOf(oldItem);
            if (index != -1)
            {
                inventory.Insert(index + 1, newItem);
            }
        }

        static void RenewItem(List<string> inventory, string item)
        {
            if (inventory.Contains(item))
            {
                inventory.Remove(item);
                inventory.Add(item);
            }
        }
    }
}
