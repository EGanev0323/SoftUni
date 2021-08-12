
using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNum(a,b,c));
        }
        public static int SmallestNum(int a,int b,int c) 
        {
            if (a<b&&a<c)
            {
                return a;
            }
            else if (b<a&b<c)
            {
                return b;
            }
            return c;
        }
    }
}
