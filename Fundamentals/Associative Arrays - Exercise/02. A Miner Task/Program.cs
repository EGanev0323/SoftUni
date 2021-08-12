using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource =Console.ReadLine();
            int quantity;
            Dictionary<string, int> countOfResources = new Dictionary<string, int>();
            while (resource!="stop")
            {

                quantity = int.Parse(Console.ReadLine());
                if (!countOfResources.ContainsKey(resource))
                {
                    countOfResources.Add(resource, 0);
                }

                countOfResources[resource] += quantity;
                resource =Console.ReadLine();

            }

            foreach (var item in countOfResources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
