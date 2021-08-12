using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int otherAn = int.Parse(Console.ReadLine());
            double price = dog * 2.50 + otherAn * 4;
            Console.WriteLine($"{price} lv.");
        }
    }
}
