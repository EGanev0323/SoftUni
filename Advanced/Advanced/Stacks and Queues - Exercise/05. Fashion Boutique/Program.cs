using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>();

            foreach (var item in nums)
            {
                clothes.Push(item);
            }
            int rackCount = 1;
            int currentRackCapacity = 0;
            while (clothes.Count != 0)
            {

                int currentCloth = clothes.Peek();
                if (currentRackCapacity + currentCloth > rackCapacity)
                {
                    rackCount++;
                    currentRackCapacity = 0;
                }
                else if (currentRackCapacity + currentCloth == rackCapacity && currentRackCapacity == 0)
                {
                    currentRackCapacity += currentCloth;
                    clothes.Pop();
                    rackCount++;
                    currentRackCapacity = 0;
                }
                else
                {
                    currentRackCapacity += currentCloth;
                    clothes.Pop();
                }

            }
            Console.WriteLine(rackCount);
        }
    }
}
