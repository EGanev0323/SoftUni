using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //Box<int> box = new Box<int>(n);
            //for (int i = 0; i < n; i++)
            //{
            //    box.Add(int.Parse(Console.ReadLine()));
            //}
            //var position = Console.ReadLine().Split().ToArray();
            //int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());

            //box.Swap(first, second);
            //box.Print();

            //int nstr = int.Parse(Console.ReadLine());
            //Box<string> boxstr = new Box<string>(nstr);
            //for (int i = 0; i < nstr; i++)
            //{
            //    string str = Console.ReadLine();
            //    boxstr.Add(str);
            //}
            //var positionstr = Console.ReadLine().Split().ToArray();
            //int firststr = int.Parse(Console.ReadLine());
            //int secondstr = int.Parse(Console.ReadLine());

            //boxstr.Swap(firststr, secondstr);
            //boxstr.Print();

            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>(n);
            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }
            var position = Console.ReadLine().Split().ToArray();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            box.Swap(first, second);
            box.Print();
        }
    }
}
