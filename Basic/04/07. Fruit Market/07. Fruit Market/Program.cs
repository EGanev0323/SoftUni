using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasKg = double.Parse(Console.ReadLine());
            double orangesKg = double.Parse(Console.ReadLine());
            double raspberriesKg = double.Parse(Console.ReadLine());
            double strawberriesKg = double.Parse(Console.ReadLine());

            double raspberyPrice = strawberryPrice / 2;
            double orangesPrice = raspberyPrice -(0.4*raspberyPrice);
            double bananasPrice = raspberyPrice-(0.8*raspberyPrice);

            double total = (raspberriesKg * raspberyPrice) + (orangesKg * orangesPrice)
                + (bananasKg * bananasPrice) + (strawberriesKg * strawberryPrice);
            Console.WriteLine($"{total:f2}");

        }
    }
}
