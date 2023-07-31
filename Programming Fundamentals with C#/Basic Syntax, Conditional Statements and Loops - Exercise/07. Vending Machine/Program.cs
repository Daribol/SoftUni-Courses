using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Start")
                {
                    break;
                }
                double coins = double.Parse(command);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "End")
                {
                    break ;
                }
                double price = 0;
                switch (product)
                {
                    case "Nuts":
                      price = 2.0;
                    break;
                    case "Water":
                      price = 0.7;
                    break;
                    case "Crisps":
                      price = 1.5;
                    break;
                    case "Soda":
                       price = 0.8;
                    break;
                    case "Coke":
                       price = 1.0;
                    break;
                  }

                if (price > 0)
                {
                    if (sum >= price)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }  
}
