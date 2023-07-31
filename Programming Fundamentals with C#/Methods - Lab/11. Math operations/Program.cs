using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static double Calculate(int num1, string command, int num2)
        {
            double result = 0;
            switch (command)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

           double result = Calculate(num1, command, num2);
           Console.WriteLine(result);
        }
    }
}
