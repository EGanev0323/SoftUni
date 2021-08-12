using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Divider dev = new Divider();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(dev.Divide(x,y));
            
        }
    }
}
