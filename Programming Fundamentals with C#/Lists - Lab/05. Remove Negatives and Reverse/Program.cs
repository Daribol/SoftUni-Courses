using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> reverseNums = new List<int>();


            nums.RemoveAll(n => n < 0);

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                nums.Reverse();
                Console.WriteLine(String.Join(" ", nums));
            }
        }
    }
}
