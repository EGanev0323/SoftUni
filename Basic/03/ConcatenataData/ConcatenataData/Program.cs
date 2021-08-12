using System;
using System.Threading;

namespace ConcatenataData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastdName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastdName}, a {age}-years old person from {town}.");
        }
    }
}
