using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maath
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());
            if ((x&1)==0)
            {
                Console.WriteLine("Number is even.");
            }
            else
            {
                Console.WriteLine("Number is odd.");
            }


            int n = int.Parse(Console.ReadLine());
            if (x<n)
            {
                Console.WriteLine("n-тия член е 1");
            }
            else
            {
                Console.WriteLine("n-тия член не е 1");
            }
        }
    }
}
