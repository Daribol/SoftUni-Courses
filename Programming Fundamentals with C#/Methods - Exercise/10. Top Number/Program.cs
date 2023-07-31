using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static bool IsTopInteger(int n)
        {
            return IsDivisibleByEight(n) && HasOddNumber(n);
        }

        static bool HasOddNumber(int n)
        {
            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                n /= 10;

            }

            return false;
        }

        static bool IsDivisibleByEight(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;

            }

            return sum % 8 == 0;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if (IsTopInteger(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
