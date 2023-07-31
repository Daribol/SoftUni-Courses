using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                int currentNumber = inputs[i];
                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
            }
            int difference = sumEven - sumOdd;
            Console.WriteLine(difference);
        }
    }
}
