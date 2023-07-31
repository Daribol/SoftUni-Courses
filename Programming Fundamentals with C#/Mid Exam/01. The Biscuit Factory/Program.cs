using System;

namespace _01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workerCount = int.Parse(Console.ReadLine());
            int competingProduction = int.Parse(Console.ReadLine());

            int countBiscuitsPerDay = biscuitsPerDay * workerCount;
            int totalBiscuits = 0;

            for (int day = 1; day <= 30; day++)
            {
                double count = 0;
                if (day % 3 == 0)
                {
                    count = countBiscuitsPerDay - (countBiscuitsPerDay * 0.25);
                    totalBiscuits += (int)count;
                }
                else
                {
                    totalBiscuits += countBiscuitsPerDay;
                }
            }

            Console.WriteLine($"You have produced {totalBiscuits:f0} biscuits for the past month.");

            double difference = Math.Abs(totalBiscuits - competingProduction);

            double percentage = difference / competingProduction * 100;

            if (totalBiscuits > competingProduction)
            {
                Console.WriteLine($"You produce {Math.Abs(percentage):f2} percent more biscuits.");
            }
            else if (totalBiscuits < competingProduction)
            {
                Console.WriteLine($"You produce {Math.Abs(percentage):f2} percent less biscuits.");
            }
        }
    }
}
