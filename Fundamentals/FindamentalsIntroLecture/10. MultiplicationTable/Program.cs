using System;

namespace _10._MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int theIntiger = int.Parse(Console.ReadLine());
            int times = 1;

            while (times!=11)
            {
                Console.WriteLine($"{ theIntiger} X {times} = {theIntiger*times}");
                times++;
            }
        }
    }
}
