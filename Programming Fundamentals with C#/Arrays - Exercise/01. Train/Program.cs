using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                wagons[i] = input;

                sum += input;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(wagons[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
