using System;
using System.Runtime.InteropServices;

namespace _05._Orders
{
    internal class Program
    {
        static void Orders(string product, int quantity)
        {
            double sum = 0;
            switch (product)
            {
                case "coffee":
                    sum = quantity * 1.50;
                    break;
                case "water":
                    sum = quantity * 1.00;
                    break;
                case "coke":
                    sum = quantity * 1.40;
                    break;
                case "snacks":
                    sum = quantity * 2.00;
                    break;
            }

            Console.WriteLine($"{sum:f2}");
        }
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Orders(product, quantity);
        }
    }
}
