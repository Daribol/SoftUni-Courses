using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fString = Console.ReadLine();
            string sString = Console.ReadLine();

            int index = sString.IndexOf(fString);

            while (index != -1)
            {
                sString = sString.Remove(index, fString.Length);
                index = sString.IndexOf(fString);
            }

            Console.WriteLine(sString);
        }
    }
}
