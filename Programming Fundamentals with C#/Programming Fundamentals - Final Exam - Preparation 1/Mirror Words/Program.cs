using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> validPairs = new List<string>();

            List<string> mirrorWords = new List<string>();

            var dict = new Dictionary<string, string>();

            var pattern = @"([\@|\#])(?<wordOne>[A-Za-z]{3,})(\1)(\1)(?<wordTwo>)[A-Za-z]{3,}(\1)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string pair = match.Value.Substring(1, match.Value.Length - 2);
                string[] words = pair.Split(new[] { "@@", "##" }, StringSplitOptions.RemoveEmptyEntries);

                validPairs.Add(pair);

                if (IsMirrorWord(words[0], words[1]))
                {
                    pair = words[0] + " <=> " + words[1];
                    mirrorWords.Add(pair);
                }
            }

            if (validPairs.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{validPairs.Count} word pairs found!");
            }

            if (mirrorWords.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
        static bool IsMirrorWord(string wordOne, string wordTwo)
        {
            char[] arr = wordOne.ToCharArray();
            Array.Reverse(arr);
            string reversedWordOne = new string(arr);

            return wordTwo.Equals(reversedWordOne);
        }
    }
}
