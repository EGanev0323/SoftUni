using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> append = input =>Console.WriteLine($"Sir {string.Join("\n"+"Sir ",input)}");
            append(names);
        }
    }
}
