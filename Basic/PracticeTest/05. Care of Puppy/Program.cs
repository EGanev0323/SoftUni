using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int foodInGrams = dogFood * 1000;
            int foodLeft = 0;
            while (input != "Adopted")
            {
                int foodGrams = int.Parse(input);
                input = Console.ReadLine();
                foodLeft += foodGrams;
            }
            if (foodLeft <= foodInGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams - foodLeft} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodLeft - foodInGrams} grams more.");
            }
        }
    }
}
