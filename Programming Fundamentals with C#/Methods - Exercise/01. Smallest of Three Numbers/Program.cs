using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static int SmallestNumbe(int num1, int num2, int num3)
        {
            int smallest = num1;
            if (num1 > num2)
            {
                smallest = num2;
                if (num2 > num3)
                {
                    smallest = num3;
                }
            }
            else if (num1 > num3)
            {
                smallest = num3;
            }

            return smallest;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int smalest = SmallestNumbe(num1, num2, num3);
            Console.WriteLine(smalest);
        }
    }
}
