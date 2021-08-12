using System;

namespace _4.BackIn30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes>=60)
            {
                hours++;
                minutes = minutes-60;
            }
            if (hours>=23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours:D1}:{minutes:D2}");
        }
    }
}
