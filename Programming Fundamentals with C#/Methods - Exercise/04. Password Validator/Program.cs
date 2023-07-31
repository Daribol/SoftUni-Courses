using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;


namespace _04._Password_Validator
{
    internal class Program
    {
        static bool LengthOfPassword(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool ConsistOfPassword(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        static bool TwoDigitsInPassword(string password)
        {
            int digitCount = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }

            if (digitCount < 2)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool lenghtCheck = LengthOfPassword(password);
            bool symbolCheck = ConsistOfPassword(password);
            bool twoDigitsCheck = TwoDigitsInPassword(password);
            
            if (!lenghtCheck)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!symbolCheck)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!twoDigitsCheck)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (lenghtCheck && symbolCheck && twoDigitsCheck)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
