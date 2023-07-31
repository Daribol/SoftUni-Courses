using System;

namespace Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                string[] arguments = command.Split(" ");
                switch (arguments[0])
                {
                    case "Abjuration":
                        input = input.ToUpper();
                        Console.WriteLine(input);
                        break;
                    case "Necromancy":
                        input = input.ToLower();
                        Console.WriteLine(input);
                        break;
                    case "Illusion":
                        int index = int.Parse(arguments[1]);
                        char letter = char.Parse(arguments[2]);

                        if (index >= 0 && index < input.Length)
                        {
                            char[] chars = input.ToCharArray();
                            chars[index] = letter;
                            input = new string(chars);
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        break;
                    case "Divination":
                        string firstSubstring = arguments[1];
                        string secondSubstring = arguments[2];

                        if (input.Contains(firstSubstring))
                        {
                            input = input.Replace(firstSubstring, secondSubstring);
                            Console.WriteLine(input);
                        }
                        break;
                    case "Alteration":
                        string substring = arguments[1];

                        if (input.Contains(substring))
                        {
                            input = input.Replace(substring, "");
                            Console.WriteLine(input);
                        }
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
            }
        }
    }
}
