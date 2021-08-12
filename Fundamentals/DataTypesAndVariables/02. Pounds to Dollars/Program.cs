using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dolars = pounds * (decimal)1.31;
            Console.WriteLine($"{dolars:f3}");
        }
    }
}
