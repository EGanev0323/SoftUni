using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    public class Person
    {
        //fields
        private string firstName;
        private string secondName;
        private string lastName;
        private int age;
        private List<BankAcc> accounts = new List<BankAcc>();

        //properties
       
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 110)
                {
                    age = value;
                }
            }
        }

        public List<BankAcc> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
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
        public void PrintPerson()
        {
            Console.WriteLine($"{FirstName} {SecondName} {LastName}: {Age} ");
        }
        public double GetBalance()
        {
            double balance = accounts.Sum(x => x.Balance);
            return balance;
        }

    }
}
