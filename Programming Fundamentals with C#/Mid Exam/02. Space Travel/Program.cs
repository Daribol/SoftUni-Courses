using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> travel = Console.ReadLine().Split("||").ToList();
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < travel.Count; i++)
            {
                string[] travelItem = travel[i].Split();
                string command = travelItem[0];

                if (command == "Travel")
                {
                    int lightYears = int.Parse(travelItem[1]);
                    if (fuel >= lightYears)
                    {
                        Console.WriteLine($"The spaceship travelled {lightYears} light-years.");
                    }
                    else if (fuel < lightYears || fuel < 0)
                    {
                        Console.WriteLine("Mission failed.");
                        break;
                    }

                    for (int j = 1; j <= lightYears; j++)
                    {
                        fuel--;
                    }
                }
                if (command == "Enemy")
                {
                    int enemyArmour = int.Parse(travelItem[1]);
                    if (ammunition >= enemyArmour)
                    {
                        for (int j = 1; j <= enemyArmour; j++)
                        {
                            ammunition--;
                        }


                        Console.WriteLine($"An enemy with {enemyArmour} armour is defeated.");
                    }
                    else
                    {
                        for (int j = 1; j <= enemyArmour; j++)
                        {
                            fuel = fuel - 2;
                        }

                        if (fuel < 0)
                        {
                            Console.WriteLine("Mission failed.");
                            break;
                        }
                        Console.WriteLine($"An enemy with {enemyArmour} armour is outmaneuvered.");
                    }
                }
                if (command == "Repair")
                {
                    int value = int.Parse(travelItem[1]);
                    int addedFuel = value;
                    fuel += addedFuel;
                    int addedAmmunition = value * 2;
                    ammunition += addedAmmunition;
                    Console.WriteLine($"Ammunitions added: {addedAmmunition}.");
                    Console.WriteLine($"Fuel added: {addedFuel}.");
                }
                if (command == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    break;
                }
            }
        }
    }
}
