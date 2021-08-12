using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squaremtr = double.Parse(Console.ReadLine());
            double price = squaremtr * 7.61;
            double discount = price * 0.18;
            double finalPrice = price - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
