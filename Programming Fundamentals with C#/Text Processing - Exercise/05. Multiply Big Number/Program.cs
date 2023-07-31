using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string largeNumber = Console.ReadLine();

            int singleDigit = int.Parse(Console.ReadLine());

            string result = MultiplyLargeNumber(largeNumber, singleDigit);
            Console.WriteLine(result);
        }
        static string MultiplyLargeNumber(string largeNumber, int singleDigit)
        {
            if (singleDigit == 0 || largeNumber == "0")
                return "0";

            int n = largeNumber.Length;
            int carry = 0;

            char[] result = new char[n + 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = largeNumber[i] - '0';
                int product = digit * singleDigit + carry;
                result[i + 1] = (char)(product % 10 + '0');
                carry = product / 10;
            }

            if (carry > 0)
                result[0] = (char)(carry + '0');

            return new string(result).TrimStart('0');
        }
    }
}
