using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //QueueBox<int> box = new QueueBox<int>();
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                box.Add(num);
            }
            Console.WriteLine(box.ToString());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(box.ToString());
            //}
            
           
        }
    }
}
