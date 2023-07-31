using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();

            var dict = new Dictionary<string, int>();

            string input;

            foreach (string participant in participants)
            {
                dict.Add(participant, 0);
            }

            while ((input = Console.ReadLine()) != "end of race")
            {
                string letters = string.Empty;

                int sum = 0;

                foreach (char c in input)
                {
                    if (char.IsLetter(c))
                    {
                        letters += c;
                    }
                    else if (char.IsDigit(c))
                    {
                        sum += int.Parse(c.ToString());
                    }
                }

                if (dict.ContainsKey(letters))
                {
                    dict[letters] += sum;
                }
            }

            dict = dict.OrderByDescending(r => r.Value).Take(3).ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"1st place: {dict.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {dict.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {dict.ElementAt(2).Key}");
        }
    }
}
