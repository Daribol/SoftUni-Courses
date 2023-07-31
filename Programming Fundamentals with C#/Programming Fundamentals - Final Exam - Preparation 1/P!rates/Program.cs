using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            var cities = new Dictionary<string, City>();

            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] cityData = command.Split("||");
                string cityName = cityData[0];
                int population = int.Parse(cityData[1]);
                int gold = int.Parse(cityData[2]);

                if (!cities.ContainsKey(cityName))
                {
                    cities[cityName] = new City(population, gold);
                }
                else
                {
                    cities[cityName].Population += population;
                    cities[cityName].Gold += gold;
                }
            }

            while ((command = Console.ReadLine()) != "End")
            {
                string[] eventData = command.Split("=>");
                string eventType = eventData[0];
                string cityName = eventData[1];

                switch (eventType)
                {
                    case "Plunder":
                        int killed = int.Parse(eventData[2]);
                        int gold = int.Parse(eventData[3]);

                        cities[cityName].Population -= killed;
                        cities[cityName].Gold -= gold;

                        Console.WriteLine($"{cityName} plundered! {gold} gold stolen, { killed} citizens killed.");

                        if (cities[cityName].Population <= 0 || cities[cityName].Gold <= 0)
                        {
                            cities.Remove(cityName);
                            Console.WriteLine($"{cityName} has been wiped off the map!");
                        }
                        break;
                    case "Prosper":
                        int addGold = int.Parse(eventData[2]);

                        if (addGold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            cities[cityName].Gold += addGold;
                            Console.WriteLine($"{addGold} gold added to the city treasury. {cityName} now has {cities[cityName].Gold} gold.");
                        }
                        break;
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var kvp in cities)
                {
                    Console.WriteLine($"{kvp.Key} -> Population: {kvp.Value.Population} citizens, Gold: {kvp.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
    class City
    {
        public City(int population, int gold)
        {
            Population = population;
            Gold = gold;
        }

        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
