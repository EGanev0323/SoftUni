using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int walks = int.Parse(Console.ReadLine());
            double calories = double.Parse(Console.ReadLine());
            //1minute=-5calories

            double totalWalks = minutes * walks;
            double burnedCalories = totalWalks * 5;
            double persantageCalories = calories * 0.5;

            if (burnedCalories > persantageCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
