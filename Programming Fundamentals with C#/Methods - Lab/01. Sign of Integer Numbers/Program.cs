using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void PrintSigns(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
        }
        static void Main(string[] args)
        {
            PrintSigns(int.Parse(Console.ReadLine()));
        }
    }
}
