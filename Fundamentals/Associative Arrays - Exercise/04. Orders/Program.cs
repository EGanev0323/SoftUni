using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            while (input[0] != "buy")
            {
                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double>());
                    products[product].Add(price);
                    products[product].Add(quantity);
                    input = Console.ReadLine().Split().ToList();
                    continue;
                }

                products[product][1] += quantity;
                if (products[product][0] != price)
                {
                    products[product][0] = price;
                }

                input = Console.ReadLine().Split().ToList();
            }

            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2} ");
            }
        }
    }
}
