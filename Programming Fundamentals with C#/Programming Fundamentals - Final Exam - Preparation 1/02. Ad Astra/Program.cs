using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace _02._Ad_Astra
{
    internal class Program
    {
        class FoodInfo
        {
            public FoodInfo(string name, string date, int calories)
            {
                Name = name;
                Date = date;
                Calories = calories;
            }
            public string Name { get; set; }
            public string Date { get; set; }
            public int Calories { get; set; }


        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<FoodInfo> foodInfos = new List<FoodInfo>();

            var pattern = @"\#(?<name>\w+|\w+\s+\w+)\#(?<date>\d{2}\/\d{2}\/\d{2})\#(?<calories>\d+)\#|\|(?<name>\w+|\w+\s+\w+)\|(?<date>\d{2}\/\d{2}\/\d{2})\|(?<calories>\d+)\|";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            int totalCalories = 0;

            foreach (Match match in matches)
            {
                string info = match.Value.Trim('|', '#');
                string[] food = info.Split('#', '|');

                string name = food[0];
                string date = food[1];
                int calories = int.Parse(food[2]);

                FoodInfo foodInfo = new FoodInfo(name, date, calories);
                
                foodInfos.Add(foodInfo);

                totalCalories += calories;
            }

            int days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (FoodInfo foodInfo in foodInfos)
            {
                Console.WriteLine($"Item: {foodInfo.Name}, Best before: {foodInfo.Date}, Nutrition: {foodInfo.Calories}");
            }
        }
    }
}
