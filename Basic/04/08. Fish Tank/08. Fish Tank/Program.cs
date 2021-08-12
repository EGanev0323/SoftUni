using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percantage = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double liters = volume * 0.001;
            double percantageP = percantage * 0.01;
            double totalLiters = liters * (1 - percantageP);
            Console.WriteLine(totalLiters);
        }
    }
}
