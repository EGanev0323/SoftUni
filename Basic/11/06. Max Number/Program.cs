﻿using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            int max = int.MinValue;
            while (input!="Stop")
            {
                int num = int.Parse(Console.ReadLine());
                if (num>max)
                {
                    max = num;
                }
              input =Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
