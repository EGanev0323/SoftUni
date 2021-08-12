using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger biggestValue = 0;
            int biggestSnow = 0;
            int biggestTime = 0;
            int biggestQuality = 0;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger totalValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (biggestValue<totalValue)
                {
                    biggestValue = totalValue;
                    biggestSnow = snowballSnow;
                    biggestTime = snowballTime;
                    biggestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{biggestSnow} : {biggestTime} = {biggestValue} ({biggestQuality})");
        }
    }
}
