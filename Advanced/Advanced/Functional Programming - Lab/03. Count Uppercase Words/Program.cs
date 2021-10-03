using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string,bool> isUpper = x => x[0] == x.ToUpper()[0];
            string[] text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(x=>isUpper(x)).ToArray();
            Console.WriteLine(string.Join("\n", text));
            
        }
    }
}
