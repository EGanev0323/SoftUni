using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    class Program
    {
        static void Main(string[] args)
        {
            Person emo = new Person { Name="Emil Ganev", Age=17};
            Person ani = new Person { Name = "Ani Ivanova", Age = 20 };

            BankAccount emosmetka = new BankAccount();  emosmetka.ID = 123; emosmetka.Balance = 1500;
            BankAccount emosmetka2 = new BankAccount();  emosmetka2.ID = 15; emosmetka2.Balance = 2000;

            BankAccount anismetka = new BankAccount(); anismetka.ID = 215; anismetka.Balance = 500;
            BankAccount anismetka2 = new BankAccount(); anismetka2.ID = 23; anismetka2.Balance = 700;
            BankAccount anismetka3 = new BankAccount(); anismetka3.ID = 240; anismetka3.Balance = 1000;

            emo.Account.Add(emosmetka);
            emo.Account.Add(emosmetka2);

            ani.Account.Add(anismetka);
            ani.Account.Add(anismetka2);
            ani.Account.Add(anismetka3);
            
            Console.WriteLine($"Balance is:{emo.GetBalance()}");
            Console.WriteLine($"Balance is: {ani.GetBalance()}");

        }
    }
}
