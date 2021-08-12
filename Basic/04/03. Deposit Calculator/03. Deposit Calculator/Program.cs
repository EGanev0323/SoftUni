using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double interestS = depositSum * interest / 100;
            double interestForMonth = interestS / 12;
            double total = depositSum + (months * interestForMonth);
            Console.WriteLine(total);
        }
    }
}
