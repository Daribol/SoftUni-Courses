using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(' ');
                switch (arguments[0])                                
                {
                    case "Add":
                        nums = AddNumber(nums, int.Parse(arguments[1]));
                        break;
                    case "Insert":
                        nums = InsertNumber(nums, int.Parse(arguments[1]), int.Parse(arguments[2]));
                        break;
                    case "Remove":
                        nums = RemoveAtIndex(nums, int.Parse(arguments[1]));
                        break;
                    case "Shift":
                        switch (arguments[1])
                        {
                            case "left":
                                nums = ShiftLeft(nums, int.Parse(arguments[2]));
                                break;
                            case "right":
                                nums = ShiftRight(nums, int.Parse(arguments[2]));
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
        static List<int> AddNumber(List<int> nums, int number)
        {
            nums.Add(number);                                        
            return nums;
        }
        static List<int> InsertNumber(List<int> nums, int number, int index)
        {
            if (IsIndexOutOfBound(nums, index))
            {
                nums.Insert(index, number);                     
            }

            return nums;
        }


        static List<int> RemoveAtIndex(List<int> nums, int index)
        {
            if (IsIndexOutOfBound(nums, index))
            {
                nums.RemoveAt(index);                                
            }

            return nums;
        }
        static bool IsIndexOutOfBound(List<int> nums, int index)
        {
            if (index < 0 || index >= nums.Count)
            {
                Console.WriteLine("Invalid index");
                return false;
            }

            return true;
        }
        static List<int> ShiftLeft(List<int> nums, int count)
        {
            count %= nums.Count;                                     

            List<int> shifted = nums.GetRange(0, count);       
            nums.RemoveRange(0, count);                        
            nums.InsertRange(nums.Count, shifted);                  
            return nums;
        }
        static List<int> ShiftRight(List<int> nums, int count)
        {
            count %= nums.Count;                                    

            int lastIndex = nums.Count - count;                     
            List<int> shifted = nums.GetRange(lastIndex, count);     
            nums.RemoveRange(lastIndex, count);                     
            nums.InsertRange(0, shifted);                     
            return nums;
        }
    }
}
