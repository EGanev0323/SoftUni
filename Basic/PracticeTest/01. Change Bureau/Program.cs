using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double chainiese = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double bitcoinInLv = bitcoin * 1168;
            double chaineseInDolars = chainiese * 0.15;
            double dolarsInLv = chaineseInDolars * 1.76;
            double allInLv = bitcoinInLv + dolarsInLv;
            double allInEuro = allInLv / 1.95;
            double euroForTrip = allInEuro - allInEuro * commision / 100;
            Console.WriteLine($"{ euroForTrip:f2}");
        }
    }
}
