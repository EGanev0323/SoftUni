using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling((double)n /capacity));
        }
    }
}
