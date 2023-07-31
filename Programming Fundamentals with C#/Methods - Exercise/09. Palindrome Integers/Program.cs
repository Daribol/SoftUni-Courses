using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                Console.WriteLine(ISPalindrome(command));
            }
        }

        static bool ISPalindrome(string command)
        {
            string first = command.Substring(0, command.Length / 2);
            char[] arr = command.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first == second;
        }
    }
}
