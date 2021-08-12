using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNum = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNum = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int maxCount = Math.Max(firstNum.Count, secondNum.Count);

            for (int i = 0; i <maxCount; i++)
            {
                if (i<firstNum.Count)
                {
                    result.Add(firstNum[i]);
                }

                if (i< secondNum.Count)
                {
                    result.Add(secondNum[i]);
                }
                
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
