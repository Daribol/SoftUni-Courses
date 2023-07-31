using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int num = int.Parse(Console.ReadLine());

             int temp = num;
             int Sum = 0;

             while (temp > 0)
             {
                  int digit = temp % 10;
                  int factorial = 1;

                  for (int i = 1; i <= digit; i++)
                  {
                      factorial *= i;
                  }

                  Sum += factorial;
                  temp /= 10;
             }

             if (Sum == num)
             {
                 Console.WriteLine("yes");
             }
             else
             {
                 Console.WriteLine("no");
             }
        }
    }

}
