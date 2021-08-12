using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10d
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int number;
        private double grade;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public double Grade { get; set; }

        public Person()
        {

        }
        public Person(string firstName, string lastName, int number, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
            this.Grade = grade;
        }
        public void Print()
        {
            Console.WriteLine($"{firstName}, {lastName}, {number}, {grade}");
        }
    }
}
