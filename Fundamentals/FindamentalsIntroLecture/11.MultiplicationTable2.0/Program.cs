using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theIntiger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{ theIntiger} X {times} = {theIntiger * times}");
                times++;
            }
            while (times <= 10);
        }
    }
}
