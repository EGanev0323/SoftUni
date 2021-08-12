using System;

namespace Basketball
{
    class Program
    {
        static void Main(string[] args)
        {
            int fee = int.Parse(Console.ReadLine());
            double trainers = fee - fee * 0.4;
            double clothes = trainers * 0.80;
            double ball = clothes / 4;
            double accesoaries = ball / 5;
            double totalCost = trainers + clothes + ball + accesoaries + fee;
            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
