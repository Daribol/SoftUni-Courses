using System;
using System.Collections.Generic;

namespace Followers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var followers = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "Log out")
            {
                string[] arguments = input.Split(": ");
                string action = arguments[0];
                string name = arguments[1];

                switch (action)
                {
                    case "New follower":
                        if (!followers.ContainsKey(name))
                        {
                            followers[name] = 0;
                        }
                        break;
                    case "Like":
                        int likes = int.Parse(arguments[2]);
                        if (!followers.ContainsKey(name))
                        {
                            followers[name] = likes;
                        }
                        else
                        {
                            followers[name] += likes;
                        }
                        break;
                    case "Comment":
                        if (!followers.ContainsKey(name))
                        {
                            followers[name] = 1;
                        }
                        else
                        {
                            followers[name]++;
                        }
                        break;
                    case "Blocked":
                        if (followers.ContainsKey(name))
                        {
                            followers.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't exist.");
                        }
                        break;
                }
            }

            Console.WriteLine($"{followers.Count} followers");
            foreach (var kvp in followers)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
