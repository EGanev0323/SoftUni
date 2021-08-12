using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();

            double moneySaved = 0;
            while (city != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                while (moneySaved < minBudget)
                {
                    moneySaved += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {city}!");
                city = Console.ReadLine();
                moneySaved = 0;
            }
        }
    }
}
