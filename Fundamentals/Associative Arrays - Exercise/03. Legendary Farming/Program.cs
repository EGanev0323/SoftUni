using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();
            legendaryItems.Add("motes", 0);
            legendaryItems.Add("fragments", 0);
            legendaryItems.Add("shards", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (legendaryItems["motes"] < 250 && legendaryItems["fragments"] < 250 && legendaryItems["shards"] < 250)
            {
                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i+1];

                    if (item=="motes"||item=="fragments"||item== "shards")
                    {
                        legendaryItems[item] += quantity;
                    }
                    else
                    {
                        if (!junk.ContainsKey(item))
                        {
                            junk.Add(item, 0);
                        }
                        junk[item] += quantity;
                    }
                }
               
            }
       
            if (legendaryItems["motes"]>=250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                legendaryItems["motes"] -= 250;
              
            }
            else if (legendaryItems["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                legendaryItems["fragments"] -= 250;
              
            }
            else if (legendaryItems["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                legendaryItems["shards"] -= 250;
               
            }

            foreach (var item in legendaryItems.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk.OrderBy(i=>i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
