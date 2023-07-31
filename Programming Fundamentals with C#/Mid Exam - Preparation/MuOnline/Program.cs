using System;
using System.Collections.Generic;
using System.Linq;

namespace MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            int bestRoom = 0;
            
            bool IsAlive = true;

            List<string> dungeon = Console.ReadLine().Split("|").ToList();

            for (int i = 0; i < dungeon.Count; i++)
            {
                string[] roomInfo = dungeon[i].Split();
                string command = roomInfo[0];
                int value = int.Parse(roomInfo[1]);

                if (command == "potion")
                {
                    if (health + value > 100)
                    {
                        int healedAmount = 100 - health;
                        health = 100;
                        Console.WriteLine($"You healed for {healedAmount} hp.");
                    }
                    else
                    {
                        health += value;
                        Console.WriteLine($"You healed for {value} hp.");
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    string monster = command;
                    health -= value;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        IsAlive = false;
                        break;
                    }
                }

            }

            if (IsAlive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
            
        }
    }
}
