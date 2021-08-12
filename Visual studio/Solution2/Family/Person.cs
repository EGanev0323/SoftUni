using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class Person
    {
        private string firstName;
        private string secondName;
        private string lastName;
        private int age;

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(string firstName, string secondName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.Age = age;
        }

        public void PrintName()
        {
            Console.WriteLine($"{FirstName} {SecondName} {LastName}-- {Age}");
        }
        
    }
}
