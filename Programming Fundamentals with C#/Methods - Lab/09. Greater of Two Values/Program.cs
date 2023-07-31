using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static int GetMax(int value1, int value2)
        {
            return Math.Max(value1, value2);
        }

        static char GetMax(char value1, char value2)
        {
            return (char)Math.Max(value1, value2);
        }

        static string GetMax(string value1, string value2)
        {
            return string.Compare(value1, value2) >= 0 ? value1 : value2;
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int int1 = int.Parse(Console.ReadLine());
                    int int2 = int.Parse(Console.ReadLine());
                    int IntResult = GetMax(int1, int2);
                    Console.WriteLine(IntResult);
                    break;
                case "char":
                    char ch1 = char.Parse(Console.ReadLine());
                    char ch2 = char.Parse(Console.ReadLine());
                    char charResult = GetMax(ch1, ch2);
                    Console.WriteLine(charResult);
                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    string stringResult = GetMax(str1, str2);
                    Console.WriteLine(stringResult);
                    break;
            }


        }
    }
}
