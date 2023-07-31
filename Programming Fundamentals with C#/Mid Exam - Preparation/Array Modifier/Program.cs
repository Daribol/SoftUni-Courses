using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandParts = command.Split();

                if (commandParts[0] == "swap")
                {
                    int index1 = int.Parse(commandParts[1]);
                    int index2 = int.Parse(commandParts[2]);
                    if (IsValidIndex(index1, array.Count) && IsValidIndex(index2, array.Count))
                    {
                        Swap(array, index1, index2);
                    }
                }
                else if (commandParts[0] == "multiply")
                {
                    int index1 = int.Parse(commandParts[1]);
                    int index2 = int.Parse(commandParts[2]);
                    if (IsValidIndex(index1, array.Count) && IsValidIndex(index2, array.Count))
                    {
                        Multiply(array, index1, index2);
                    }
                }
                else if (commandParts[0] == "decrease")
                {
                    Decrease(array);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }

        static void Swap(List<int> array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        static void Multiply(List<int> array, int index1, int index2)
        {
            array[index1] *= array[index2];
        }

        static void Decrease(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                array[i]--;
            }
        }

        static bool IsValidIndex(int index, int arrayLength)
        {
            return index >= 0 && index < arrayLength;
        }
    }
}
