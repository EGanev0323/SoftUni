using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzelsCount = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double toysPrice = puzzelsCount * 2.60 + talkingDolls * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;
            int toysCount = puzzelsCount + talkingDolls + teddyBears + minions + trucks;

            double totalPrice;
            double profit;
            if (toysCount>=50)
            {
                 totalPrice = toysPrice - toysPrice * 0.25;
                double rent = totalPrice * 0.1;
                profit = totalPrice - rent;
            }
            else
            {
                double rent = toysPrice * 0.1;
                profit = toysPrice - rent;
            }

            if (profit>=vacationPrice)
            {
                Console.WriteLine($"Yes! {profit-vacationPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacationPrice-profit:f2} lv needed.");
            }

        }
    }
}
