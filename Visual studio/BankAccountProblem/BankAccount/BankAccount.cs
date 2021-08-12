using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public int ID { get; set; }
        public decimal Balance { get; set; }

        public BankAccount() { }

        public BankAccount(int  id, decimal balance)
        {
            this.ID = id;
            this.Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount<=0)
            {
                throw new ArgumentException("Депосита не трябва да бъде нула или отрицателен!");
            }
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount<=0)
            {
                throw new ArgumentException("Не може да изтеглите пари!");
                
            }
            this.Balance -= amount;
        }
    }
}
