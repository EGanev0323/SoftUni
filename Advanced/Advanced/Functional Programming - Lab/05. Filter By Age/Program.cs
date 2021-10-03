using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Person
    {
        public string Name;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] namesWithAge = Console.ReadLine().Split(", ");
                string name = namesWithAge[0];
                int age = int.Parse(namesWithAge[1]);
                Person person = new Person();
                person.Age = age;
                person.Name = name;
                people.Add(person);
            }

            string condition = Console.ReadLine(); //younger/ older
            int compareAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine(); //name/age/name age

            Func<Person, bool> filter = p => true;
            if (condition == "younger")
            {
                filter = p => p.Age < compareAge;
            }
            else if (condition=="older")
            {
                filter = p => p.Age >= compareAge;
            }

            var peopleFilter = people.Where(filter);


            if (format=="name")
            {
                foreach (var person in peopleFilter)
                {
                    Console.WriteLine($"{person.Name}");
                }
            }
            else if (format=="age")
            {
                foreach (var person in peopleFilter)
                {
                    Console.WriteLine($"{person.Age}");
                }
            }
            else if (format=="name age")
            {
                foreach (var person in peopleFilter)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
        }
    }
}
