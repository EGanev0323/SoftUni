using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> family = new List<Person>
            {
                new Person{ FirstName="Gosho", SecondName="Pertow", LastName="Ivanow", Age=16 },
                new Person{ FirstName="Petur", SecondName="Emilow", LastName="Ivanow", Age=42 },
                new Person{ FirstName="Domitriq", SecondName="Ivaylowa", LastName="Ivanowa", Age=42 },
                new Person{ FirstName="Emil", SecondName="Borisow", LastName="Ivanow", Age=72 },
                new Person{ FirstName="Petia", SecondName="Petrowa", LastName="Ivanowa", Age=16 }

            };

            foreach (var person in family)
            {
                person.PrintName();
            }
        }
    }
}
