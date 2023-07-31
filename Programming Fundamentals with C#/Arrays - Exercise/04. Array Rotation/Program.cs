using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int length = arr.Length;
            for (int i = 0; i < rotations; i++)
            {
                int lastElement = arr[0];

                for (int j = 0; j < length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[length - 1] = lastElement;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
