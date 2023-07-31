using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static double GetRectangleArea(double width, double height)
        {
            return (width * height);
        }
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, height);
            Console.WriteLine(area);
        }
    }
}
