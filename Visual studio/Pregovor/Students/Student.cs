using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        private string firstName;
        private string lastName;
        private double grade;
        

        public string FirstName { get; set; }       
        public string LastName { get; set; }
        public double Grade{ get; set; }

        //constuctors
        public Student() { }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        //methods
        public void PrintStudent()
        {
            Console.WriteLine($"{FirstName} {LastName}: {Grade}");
        }
    }
}
