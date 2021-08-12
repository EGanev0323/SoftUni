using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] dayOfWeek = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (n <= 0 || n > 7)
            {

                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine($"{dayOfWeek[n - 1]}");
            }

        }
    }
}
