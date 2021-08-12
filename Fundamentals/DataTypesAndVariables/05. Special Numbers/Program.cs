﻿using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int digit = i;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                bool isSpecial = false;
                if (sum==5||sum==7||sum==11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }
           
        }
    }
}
