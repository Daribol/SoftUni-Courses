using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void CharactersInRange(char ch1, char ch2)
        {
            if (ch2 < ch1)
            {
                char temp = ch1;
                ch1 = ch2;
                ch2 = temp;
            }

            for (char i = ch1; i < ch2; i++)
            {
                if (i == ch1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

        }
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            CharactersInRange(ch1, ch2);
        }
    }
}
