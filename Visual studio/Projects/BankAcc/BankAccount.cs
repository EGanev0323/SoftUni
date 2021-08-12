using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public int ID { get; set; }
        public decimal Balance { get; set; }

        public BankAccount() { }
        public BankAccount(int id, decimal balance)
        {
            this.ID = id;
            this.Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("No enought money!!!");
            }
        }
        public override string ToString()
        {
            return $"Acount {this.ID}, balance{this.Balance:f2}";
        }
        
    }
}
