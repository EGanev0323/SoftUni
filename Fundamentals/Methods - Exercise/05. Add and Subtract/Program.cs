using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(a,b,c));
        }
        public static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public static int Subtract(int a,int b,int c)
        {
            int subtract = Sum(a, b) - c;
                return subtract;
        }
    }
}
