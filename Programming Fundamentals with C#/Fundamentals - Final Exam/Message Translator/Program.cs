using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> translators = new List<string>();

            string pattern = @"!(?<command>[A-Z][a-z]+)!\s*:\s*\[(?<message>[A-Za-z]{8,})\]$";

            var regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    string command = match.Groups["command"].Value;
                    string message = match.Groups["message"].Value;

                    translators.Add(input);

                    int[] asciiNums = new int[message.Length];
                    for (int j = 0; j < message.Length; j++)
                    {
                        asciiNums[j] = (int)message[j];
                    }
                    Console.WriteLine($"{command}: {string.Join(" ", asciiNums)}");
                }

                if (!translators.Contains(input))
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
