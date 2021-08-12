using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string deposit = Console.ReadLine();
            double total = 0.0;

            while (deposit != "NoMoreMoney")
            {
                double amount = double.Parse(Console.ReadLine());
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                deposit = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:f2}");

        }
    }
}
