using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traainiship
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n, ost, p;
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                ost = n % p;
                stack.Push(ost);
                n = n / p;
            }
            while (stack.Count != 0)
            {
                ost = stack.Pop();

                switch (ost)
                {
                    case 0: Console.Write(ost); break;
                    case 1: Console.Write(ost); break;
                    case 2: Console.Write(ost); break;
                    case 3: Console.Write(ost); break;
                    case 4: Console.Write(ost); break;
                    case 5: Console.Write(ost); break;
                    case 6: Console.Write(ost); break;
                    case 7: Console.Write(ost); break;
                    case 8: Console.Write(ost); break;
                    case 9: Console.Write(ost); break;
                    case 10: Console.Write('A'); break;
                    case 11: Console.Write('B'); break;
                    case 12: Console.Write('C'); break;
                    case 13: Console.Write('D'); break;
                    case 14: Console.Write('E'); break;
                    case 15: Console.Write('F'); break;
                 }
            }
            Console.WriteLine();
        }
       
    }
}
    

