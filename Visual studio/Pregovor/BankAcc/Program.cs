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
            Person emo = new Person { FirstName = "Emil", SecondName = "Georgiev", LastName = "Ganev", Age = 17 };

            BankAcc smetka = new BankAcc { ID=1, Balance= 1337000};
            BankAcc smetka2 = new BankAcc { ID = 2, Balance = 163000 };
            
            emo.Accounts.Add(smetka);
            emo.Accounts.Add(smetka2);
            emo.PrintPerson();
            Console.WriteLine($"Balance is:{emo.GetBalance()}");
        }
    }
}
