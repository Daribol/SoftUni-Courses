using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    arr2[i] = numbers[j];
                    arr1[i] = numbers[j + 1];
                }
            }

            for (int i = 0; i < n; i+= 2)
            {
                int temp = 0;
                temp = arr2[i];
                arr2[i] = arr1[i];
                arr1[i] = temp;
            }

            string first = string.Join(" ", arr1);
            string second = string.Join(" ", arr2);

            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
