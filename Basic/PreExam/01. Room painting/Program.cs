using System;

namespace _01._Room_painting
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintBox = int.Parse(Console.ReadLine());
            int tapeti = int.Parse(Console.ReadLine());
            double glove = double.Parse(Console.ReadLine());
            double chetka = double.Parse(Console.ReadLine());
            double countGlove = Math.Ceiling(tapeti * 0.35);
            double countChetka = Math.Floor(paintBox * 0.48);
            double paintSum = paintBox * 21.50;
            double tapetSum = tapeti * 5.20;
            double totalGlove = countGlove * glove;
            double totalChetki = countChetka * chetka;
            double midSum = totalGlove + totalChetki + paintSum + tapetSum;
            double delivery = midSum * 1 / 15;
            Console.WriteLine($"This delivery will cost {delivery:f2} lv.");
            //5мин
        }
    }
}
