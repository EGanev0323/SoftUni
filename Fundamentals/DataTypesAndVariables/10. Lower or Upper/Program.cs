using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char text = char.Parse(Console.ReadLine());
            if (char.IsLower(text))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(text))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
