using System;

namespace _01._Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var text =Console.ReadLine();
            while (text!="Stop")
            {
                text =Console.ReadLine();
            }
        }
    }
}
