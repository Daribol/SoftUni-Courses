using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static int SumOfTwoInt(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static int SubtractOfSumWithThirdInteger(int num1, int num2, int num3)
        {
            int sum = SumOfTwoInt(num1, num2);
            int subtract = sum - num3;
            return subtract;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int subtract = SubtractOfSumWithThirdInteger(num1, num2, num3);
            Console.WriteLine(subtract);
        }
    }
}
