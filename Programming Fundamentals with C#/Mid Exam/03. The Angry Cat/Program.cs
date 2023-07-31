using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRating = Console.ReadLine().Split(",").Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();

            int leftDamage = CalculateDamage(priceRating,entryPoint, -1, typeOfItems);
            int rightDamage = CalculateDamage(priceRating, entryPoint, 1, typeOfItems);


            string leftPosition = "Left";
            string rightPosition = "Right";

            if (GetPosition(leftPosition, rightPosition, leftDamage, rightDamage) == "Right")
            {
                Console.WriteLine($"Right - {rightDamage}");
            }
            else if (GetPosition(leftPosition, rightPosition, leftDamage, rightDamage) == "Left")
            {
                Console.WriteLine($"Left - {leftDamage}");
            }
                
        }
        static int CalculateDamage(List<int> priceRating, int entryPoint, int direction, string typeOfItems)
        {
            int damage = 0;
            int currentIndex = entryPoint + direction;

            while (currentIndex >= 0 && currentIndex < priceRating.Count)
            {
                if (typeOfItems == "cheap" && priceRating[currentIndex] < priceRating[entryPoint])
                {
                    damage += priceRating[currentIndex];
                }
                else if (typeOfItems == "expensive" && priceRating[currentIndex] >= priceRating[entryPoint])
                {
                    damage += priceRating[currentIndex];
                }

                currentIndex += direction;
            }

            return damage;
        }

        static string GetPosition(string leftPosition, string rightPosition, int leftDamage, int rightDamage)
        {
            if (leftDamage >= rightDamage)
            {
                return leftPosition;
            }
            else
            {
                return rightPosition;
            }
        }
    }
}
