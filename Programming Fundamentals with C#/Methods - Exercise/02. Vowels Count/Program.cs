using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void GetCountOfVowels(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = char.ToLower(input[i]);
                if (c == 'a' || c == 'e' || c == 'o' || c == 'u' || c == 'i')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetCountOfVowels(input);
        }
    }
}
