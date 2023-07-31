using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> resultNums = new List<int>();

            int iterations = Math.Max(nums1.Count, nums2.Count);

            for (int i = 0; i < iterations; i++)
            {
                if (i < nums1.Count)
                {
                    resultNums.Add(nums1[i]);
                }
                
                if (i < nums2.Count)
                {
                    resultNums.Add(nums2[i]);
                }
            }

            Console.WriteLine(String.Join(" ", resultNums));
        }
    }
}
