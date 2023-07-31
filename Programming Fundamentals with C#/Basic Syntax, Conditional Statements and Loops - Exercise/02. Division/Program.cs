using System;
using System.Diagnostics.CodeAnalysis;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool divisible = false;
            int maxDiv = 0;
            for (int i = 2; i <= 10; i++)
            {
                if (i == 5 || i == 4 || i == 8 || i == 9)
                {
                    continue;
                }
                if (num % i == 0)
                {
                    divisible = true;
                    maxDiv = i;
                }
            }

            if (!divisible)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine("The number is divisible by " + maxDiv);
            }
        }
    }
}

