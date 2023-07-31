using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int balanceIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    balanceIndex = i;
                    break;
                }
            }

            if (balanceIndex != -1)
            {
                Console.WriteLine(balanceIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
