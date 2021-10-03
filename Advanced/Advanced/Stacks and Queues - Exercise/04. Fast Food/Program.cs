using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> clients = new Queue<int>();
            foreach (var item in orders)
            {
                clients.Enqueue(item);
            }

            int maxNum = 0;
            

            while (quantityOfFood > 0 && clients.Count > 0)
            {
                int currentOrder = clients.Peek();
                if (currentOrder>maxNum)
                {
                    maxNum = currentOrder;
                }

                if (quantityOfFood - currentOrder < 0) 
                {
                    break;
                }
                quantityOfFood -= currentOrder;
                clients.Dequeue();
               

            }

            Console.WriteLine(maxNum);
            if (clients.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write($"Orders left: {string.Join(" ", clients)}");
            }
        }
    }
}
