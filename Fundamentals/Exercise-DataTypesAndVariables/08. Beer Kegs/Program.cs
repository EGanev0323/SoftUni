using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggerKeg = 0;
            string biggestKegName = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string beerName =Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * (radius * radius * height);
                if (biggerKeg<volume)
                {
                    biggerKeg = volume;
                    biggestKegName = beerName;
                }

            }

            Console.WriteLine(biggestKegName);
        }
    }
}
