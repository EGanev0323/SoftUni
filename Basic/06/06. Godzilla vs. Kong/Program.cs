using System;
using System.Threading.Channels;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int screenWriters = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            double clothesPrice=screenWriters*clothes;
            if (screenWriters>150)
            {
                clothesPrice = clothesPrice - clothesPrice * 0.1;
            }
            else
            {
                clothesPrice = clothesPrice;
            }
            double decorAndClother = clothesPrice + decor;
            if (decorAndClother>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs { decorAndClother-budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-decorAndClother:f2} leva left.");
            }
        }
    }
}
