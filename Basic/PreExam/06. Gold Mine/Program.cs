using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());
            double averageDig = 0;
            int days = 0;
            double sum = 0;
            double averageDigForDay = 0;
            for (int i = 1; i <= locations; i++)
            {
                sum = 0;
                averageDig = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                for (int j = 0; j < days; j++)
                {
                    double digForDay = double.Parse(Console.ReadLine());
                    sum += digForDay;
                }
                averageDigForDay = sum / days;
                if (averageDigForDay >= averageDig)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageDigForDay:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {averageDig - averageDigForDay:f2} gold.");
                }
            }
        }
    }
}
