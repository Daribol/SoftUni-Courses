﻿using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = 0;
            int trashedMouses = 0;
            int trashedKeyboards = 0 ;
            int trashedDisplays = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadsets++;
                }
                if (i % 3 == 0)
                {
                    trashedMouses++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboards++;
                    if (trashedKeyboards % 2 == 0 && trashedKeyboards > 0)
                    {
                        trashedDisplays++;
                    }
                }    
            }
            double total = trashedHeadsets * headsetPrice + trashedMouses * mousePrice + trashedKeyboards * keyboardPrice + trashedDisplays * displayPrice;

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
