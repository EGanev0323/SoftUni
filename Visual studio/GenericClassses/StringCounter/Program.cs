using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                box.Add(str);
            }
            string element = Console.ReadLine();
            Console.WriteLine(box.BiggerThan(element));


        }
    }
}
