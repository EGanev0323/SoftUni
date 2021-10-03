using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lenth = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = lenth[0];
            int m = lenth[1];
            HashSet<int> nSet = new HashSet<int>();
            HashSet<int> mSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nSet.Add(num);

            }

            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                mSet.Add(num);
            }

            List<int> numbers = nSet.Intersect(mSet).ToList();
            Console.WriteLine(string.Join(" ",numbers));
           
        }
    }
}
