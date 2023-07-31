using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int totalTry = 0;

            string reverse = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                reverse += username[i];
            }

            bool logged = false;

            for (int i = 1; i <= 4; i++)
            {
                string password = Console.ReadLine();
                totalTry++;
                if (password == reverse)
                {
                    logged = true;
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (totalTry >= 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
