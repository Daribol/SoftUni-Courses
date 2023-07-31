using System;

namespace _11._Orders
{
    internal class Program
    {
         static void Main(string[] args)
         {
             int orders = int.Parse(Console.ReadLine());
             double totalPrice = 0;
             for (int i = 0; i < orders; i++)
             {
                 double pricePerCapsula = double.Parse(Console.ReadLine());
                 int days = int.Parse(Console.ReadLine());
                 int capsulaCount = int.Parse(Console.ReadLine());
                 double price = (days * capsulaCount) * pricePerCapsula;
                 totalPrice += price;
                 Console.WriteLine($"The price for the coffee is: ${price:F2}");

             }
             Console.WriteLine($"Total: ${totalPrice:F2}");
         }
    }
}



