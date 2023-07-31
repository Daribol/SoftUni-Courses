using System;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split();

            int bestCount = 0;
            string bestSymbol = "";

            for (int i = 0; i < symbols.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < symbols.Length; j++)
                {
                    if (symbols[i] == symbols[j])
                    {
                        count++;
                        if (bestCount < count)
                        {
                            bestCount = count;
                            bestSymbol = symbols[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }  
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{bestSymbol} ");
            }
        }
    }
}
