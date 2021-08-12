using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();

        public string Name { get; set; }
        public int Age { get; set; }
        public List<BankAccount> Account { get;set; }
        public Person()
        {

        }

        public Person(string name, int age):this(name,age,new List<BankAccount>())
        {

        }
        public Person(string name, int age, List<BankAccount>accounts)
        {
            Name = name;
            Age = age;
            this.Account = accounts;
        }
        public decimal GetBalance()
        {
            return this.Account.Sum(x => x.Balance);
        }
    }
}
