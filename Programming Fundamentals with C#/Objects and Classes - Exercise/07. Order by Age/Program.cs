using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Person> persons = new List<Person>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(' ');
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person(name, id, age);
                persons.Add(person);
            }

            persons = persons.OrderBy(person => person.Age).ToList();

            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
