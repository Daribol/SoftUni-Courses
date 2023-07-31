using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();


            DetonateNumbers(numbers, input[0], input[1]);

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }

        static void DetonateNumbers(List<int> numbers, int bombNumber, int bombPower)
        {
            List<int> remainingElements = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int leftIndex = Math.Max(i - bombPower, 0);
                    int rightIndex = Math.Min(i + bombPower, numbers.Count - 1);

                    i = rightIndex;

                    for (int j = leftIndex; j <= rightIndex; j++)
                    {
                        numbers[j] = 0;
                    }
                }
                else
                {
                    remainingElements.Add(numbers[i]);
                }
            }
            numbers = remainingElements;
        }
    }
}
