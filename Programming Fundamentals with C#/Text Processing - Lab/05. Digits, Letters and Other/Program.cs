using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = "";
            string letters = "";
            string other = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digits += c;
                }
                else if(char.IsLetter(c))
                {
                    letters += c;
                }
                else
                {
                    other += c;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
