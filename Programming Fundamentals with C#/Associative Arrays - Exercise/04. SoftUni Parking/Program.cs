using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "register":
                        string registerName = command[1];
                        string licensePlate = command[2];

                        if (parking.ContainsKey(registerName))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        else
                        {
                            Console.WriteLine($"{registerName} registered {licensePlate} successfully");
                            parking.Add(registerName, licensePlate);
                        }
                        break;
                    case "unregister":
                        string unregisterName = command[1];
                        if (!parking.ContainsKey(unregisterName))
                        {
                            Console.WriteLine($"ERROR: user {unregisterName} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{unregisterName} unregistered successfully");
                            parking.Remove(unregisterName);
                        }
                        break;
                }
            }

            foreach (var kvp in parking)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
