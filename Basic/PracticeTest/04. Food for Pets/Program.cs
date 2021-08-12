using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodQuantity = double.Parse(Console.ReadLine());
            double dogFood = 0;
            double catFood = 0;
            double foodForDay = 0;
            double biscuitsC = 0;
            double allFoood = 0;
            for (int i = 1; i <= days; i++)
            {
                int dogE = int.Parse(Console.ReadLine());
                dogFood += dogE;
                int catE = int.Parse(Console.ReadLine());
                catFood += catE;
                foodForDay = dogE + catE;
                if (i % 3 == 0)
                {
                    double biscuits = foodForDay * 0.1;
                    biscuitsC += biscuits;
                }
                allFoood += foodForDay;
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuitsC)}gr.");
            Console.WriteLine($"{allFoood / foodQuantity * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogFood / allFoood * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{catFood / allFoood * 100:f2}% eaten from the cat.");
        }
    }
}
