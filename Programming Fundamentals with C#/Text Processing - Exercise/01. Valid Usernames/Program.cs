using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (IsValidUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        static bool IsValidUsername(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            foreach (char c in username)
            {
                if (!(char.IsLetterOrDigit(c) || c == '-' || c == '_'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
