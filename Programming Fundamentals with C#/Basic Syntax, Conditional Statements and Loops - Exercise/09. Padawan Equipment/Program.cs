using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float lightsabersPrice = float.Parse(Console.ReadLine());
            float robesPrice = float.Parse(Console.ReadLine());
            float beltsPrice = float.Parse(Console.ReadLine());

            int lightsabersCount = (int)Math.Ceiling(students * 1.1);
            double sum = lightsabersPrice * lightsabersCount + robesPrice * students + beltsPrice * (students - students / 6);
            
            if (money >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {sum - money:f2}lv more.");
            }
        }
    }
}
