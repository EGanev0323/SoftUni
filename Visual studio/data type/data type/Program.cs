using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи а:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи б:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum= {a+b}");
            Console.WriteLine($"Minus= {a-b}");
            Console.WriteLine($"Umnoj={a*b}");
            Console.WriteLine($"Delene={(double)a/b}");
        }
    }
}
