using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = string.Empty;
            string extension = string.Empty;

            string file = Console.ReadLine();

            int lastSeparatorIndex = file.LastIndexOf('\\');
            int extensionIndex = file.LastIndexOf('.');

            if (lastSeparatorIndex != -1 && extensionIndex != -1 && extensionIndex > lastSeparatorIndex)
            {
                fileName = file.Substring(lastSeparatorIndex + 1, extensionIndex - lastSeparatorIndex - 1);
                extension = file.Substring(extensionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
