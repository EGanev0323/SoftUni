using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesPlus15 = minutes + 15;

            
            if (minutesPlus15>=60)
            {
                hours = hours + 1;
                minutes = minutesPlus15 - 60;
            }
            else
            {
                minutes = minutesPlus15;
            }
            if (hours>23)
            {
                hours = hours - 24;
            }

            if (minutes<10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
