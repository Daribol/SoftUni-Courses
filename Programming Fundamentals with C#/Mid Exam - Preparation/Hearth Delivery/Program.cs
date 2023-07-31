using System;
using System.Collections.Generic;
using System.Linq;

namespace Hearth_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> hurts = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            int position = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Love!")
                {
                    break;
                }

                string [] parts = command.Split();
                int jumpLenght = int.Parse(parts[1]);

                position = position + jumpLenght;

                if (position > hurts.Count - 1)
                {
                    position = 0;
                }

                if (hurts[position] == 0)
                {
                    Console.WriteLine($"Place {position} already had Valentine's day.");
                }
                else
                {
                    hurts[position] -= 2;

                    if (hurts[position] == 0)
                    {
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                }
            }

            Console.WriteLine($"Cupid's last position was {position}.");
            int failers = 0;
            for (int i = 0; i < hurts.Count; i++)
            {
                if (hurts[i] > 0)
                {
                    failers++;
                }
            }

            if (failers != 0)
            {
                Console.WriteLine($"Cupid has failed {failers} places.");
                return;
            }
            Console.WriteLine("Mission was successful.");
        }
    }
}
