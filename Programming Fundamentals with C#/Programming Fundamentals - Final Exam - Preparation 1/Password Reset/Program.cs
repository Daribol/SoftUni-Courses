using System;

namespace Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] arguments = command.Split(" ");

                switch (arguments[0])
                {
                    case "TakeOdd":
                        password = TakeOdd(password);
                        break;
                    case "Cut":
                        int index = int.Parse(arguments[1]);
                        int length = int.Parse(arguments[2]);
                        password = Cut(password, index, length);
                        break;
                    case "Substitute":
                        string substring = arguments[1];
                        string substitute = arguments[2];
                        password = Substitute(password, substring, substitute);
                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
        static string TakeOdd(string password)
        {
            string oddChars = "";
            for (int i = 1; i < password.Length; i+=2)
            {
                oddChars += password[i];
            }

            Console.WriteLine(oddChars);
            return oddChars;
        }
        static string Cut(string password, int index, int length)
        {
            string substring = password.Substring(index, length);
            int substringIndex = password.IndexOf(substring);
            if (substringIndex >= 0)
            {
                password = password.Remove(substringIndex, length);
            }

            Console.WriteLine(password);
            return password;
        }
        static string Substitute(string password, string substring, string substitute)
        {
            if (password.Contains(substring))
            {
                password = password.Replace(substring, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace! ");
            }

            return password;
        }
    }
}
