using System;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] arguments = input.Split('|');

                string command = arguments[0];

                switch (command)
                {
                    case "Insert":
                        int indexToInsert = int.Parse(arguments[1]);
                        string valueToInsert = arguments[2];
                        message = message.Insert(indexToInsert, valueToInsert);
                        break;
                    case "ChangeAll":
                        string stringToReplace = arguments[1];
                        string replace = arguments[2];
                        message = message.Replace(stringToReplace, replace);
                        break;
                    case "Move":
                        int countOfLetters = int.Parse(arguments[1]);
                        string temp = message.Substring(0, countOfLetters);
                        message = message.Remove(0, countOfLetters);
                        message = message + temp;
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
