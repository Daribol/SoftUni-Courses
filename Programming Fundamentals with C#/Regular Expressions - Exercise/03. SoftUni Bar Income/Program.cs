using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            double totalIncome = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                //var regex = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[A-Za-z]+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";

                var regex = @"\%([A-Z][a-z]+)\%[^|$%.]*\<(\w+)\>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+(?:\.\d+)?)\$";
                var customers = Regex.Match(input, regex);

                if (customers.Success)
                {
                    string customer = customers.Groups[1].Value;
                    string product = customers.Groups[2].Value;
                    int count = int.Parse(customers.Groups[3].Value);
                    double price = double.Parse(customers.Groups[4].Value);

                    double totalPrice = price*count;

                    totalIncome += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }

            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
