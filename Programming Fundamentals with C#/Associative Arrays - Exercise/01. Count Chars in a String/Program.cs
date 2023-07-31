using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var chars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == ' ')
                {
                    continue;
                }
                if (!chars.ContainsKey(c))
                {
                    chars.Add(c, 0);
                }

                chars[c]++;
            }

            foreach (var kvp in chars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
