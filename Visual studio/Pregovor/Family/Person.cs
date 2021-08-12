using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Person
    {
        //fields
        private string firstName;
        private string secondName;
        private string lastName;
        private int age;

        //properties
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
           get { return age; }
            set
            {
                if (value>0 && value < 110)
                {
                    age = value;
                }
            }
        } 
        

        //constuctors
        public Person() { }

        public Person(string firstName, string secondName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.Age = age;
        }

        //methods
        public void IntroduseYourself()
        {
            Console.WriteLine($"Hello! I am {FirstName} {SecondName} {LastName} and i am  {Age} years old.");
        }
    }
}
