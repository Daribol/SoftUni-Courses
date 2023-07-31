using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static double GetFactorial(int num)
        {
            double factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double result = GetFactorial(num1) / GetFactorial(num2);
            Console.WriteLine($"{result:f2}");
        }
    }
}
