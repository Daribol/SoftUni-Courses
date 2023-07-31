using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int digits = number % 10;
                if (digits % 2 == 0)
                {
                    sum += digits;
                }
                number /= 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int digits = number % 10;
                if ((digits % 2) != 0)
                {
                    sum += digits;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);

            return evenSum * oddSum;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }
    }
}
