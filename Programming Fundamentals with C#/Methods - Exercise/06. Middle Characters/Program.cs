using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void MiddleCharacter(string input)
        {
            int length = input.Length;
            int middle = length / 2;

            if (length % 2 == 0)
            {
                char middleChar1 = input[middle - 1];
                char middleChar2 = input[middle];
                Console.WriteLine($"{middleChar1}{middleChar2}");
            }
            else
            {
                char middleChar = input[middle];
                Console.Write(middleChar);
            }

        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MiddleCharacter(input);
        }
    }
}
