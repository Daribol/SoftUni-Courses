using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            float price = 0f;
            float pricePerPerson = 0f;

            switch (typeOfGroup)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 8.45f;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80f;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46f;
                            break;
                    }
                    price = countPeople * pricePerPerson;
                if (countPeople >= 30)
                    {
                        price = price - (price * 0.15f);
                    }
                break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 10.90f;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60f;
                            break;
                        case "Sunday":
                            pricePerPerson = 16f;
                            break;
                    }
                    if (countPeople >= 100)
                    {
                        countPeople -= 10;
                    }
                    price = countPeople * pricePerPerson;
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 15f;
                            break;
                        case "Saturday":
                            pricePerPerson = 20f;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50f;
                            break;
                    }
                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        price = price - (price * 0.05f);
                    }
                    price = countPeople * pricePerPerson;
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
