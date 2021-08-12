using System;

namespace _02._Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int bottels = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());
            double totalBottelPrice = bottels * 1.20;
            double chipsCost = totalBottelPrice * 0.45;
            double totalChipsPice = Math.Ceiling(chipsCost * chips);
            double totalSum = totalBottelPrice + totalChipsPice;
            if (totalSum <= budget)
            {
                Console.WriteLine($"{name} bought a snack and has {budget - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {totalSum - budget:f2} more leva!");
            }
        }
    }
}
