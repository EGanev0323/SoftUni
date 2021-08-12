using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washer = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double savedCash = 0;
            int toys = 0;
            double moneyPresent = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    savedCash +=moneyPresent;
                    savedCash--;
                    moneyPresent += 10;
                    
                }
                else
                {
                    toys++;
                }
            }
            double toyCash = toysPrice * toys;
            savedCash += toyCash;
            

            if (washer<=savedCash)
            {
                Console.WriteLine($"Yes! {savedCash-washer:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washer-savedCash:f2}");
            }
            
        }
    }
}
