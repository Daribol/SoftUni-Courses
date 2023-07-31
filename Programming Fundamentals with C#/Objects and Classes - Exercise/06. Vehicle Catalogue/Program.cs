using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalog
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, decimal horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Horsepower { get; set; }

        public string Capitalize(string value)
        {
            char[] charArray = value.ToCharArray();
            if (char.IsLower(charArray[0]))
            {
                charArray[0] = char.ToUpper(charArray[0]);
            }
            return new string(charArray);
        }
        public string Print()
        {
            string result = "";
            result += $"Type: {Capitalize(Type)}\n";
            result += $"Model: {Model}\n";
            result += $"Color: {Color}\n";
            result += $"Horsepower: {Horsepower}";
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> catalogue = new List<Vehicle>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                decimal horsePower = decimal.Parse(tokens[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                catalogue.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle foundVehicle = catalogue.Find(vehicle => vehicle.Model == input);

                if (foundVehicle != null)
                {
                    Console.WriteLine(foundVehicle.Print());
                }
            }

            decimal averageHP = catalogue
                .Where(vehicle => vehicle.Type == "car")
                .Select(vehicle => vehicle.Horsepower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHP:f2}.");

            averageHP = catalogue
                .Where(vehicle => vehicle.Type == "truck")
                .Select(vehicle => vehicle.Horsepower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:f2}.");
        }
    }
}
