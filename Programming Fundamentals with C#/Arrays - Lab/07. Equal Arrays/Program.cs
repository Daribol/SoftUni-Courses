using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            bool identical = true;

            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] != input2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    identical = false;
                    break;
                }
                sum += input1[i];

            }
            if (identical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
