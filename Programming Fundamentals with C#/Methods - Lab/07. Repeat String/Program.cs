using System;
using System.Linq;
using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        static string RepeatString(string str, int n)
        {
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += str;
            }

            return result;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatString(str, n);
            Console.WriteLine(result);
        }
    }
}
