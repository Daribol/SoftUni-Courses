using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using _01._Furniture;

namespace _01._Furniture
{
    class Furniture
    {
        public Furniture(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Total()
        {
            return Price * Quantity;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();
            decimal totalMoneySpend = 0;

            var regex = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Regex r = new Regex(regex);

                var collection = r.Matches(input);

                foreach (Match match in collection)
                {
                    string furniture = match.Groups["furniture"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    Furniture f = new Furniture(furniture, price, quantity);
                    furnitures.Add(f);
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                totalMoneySpend += furniture.Total();
            }

            Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");
        }
    }
}
