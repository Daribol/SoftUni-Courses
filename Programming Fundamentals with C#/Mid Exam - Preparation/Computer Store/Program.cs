using System;
using System.Data;

namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            double priceWithoutTaxes = 0;
            double priceWithTaxes = 0;
            double discount = 0;
            
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "special")
                {
                    priceWithTaxes = priceWithoutTaxes * 0.2;
                    totalPrice = priceWithoutTaxes + priceWithTaxes;
                    discount = 0.1 * totalPrice;
                    totalPrice = totalPrice - discount;
                    break;
                }
                else if (command == "regular")
                {
                    priceWithTaxes = priceWithoutTaxes * 0.2;
                    totalPrice = priceWithoutTaxes + priceWithTaxes;
                    break;
                }

                double price = double.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                priceWithoutTaxes += price;

            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {priceWithTaxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }

            
        }
    }
}
