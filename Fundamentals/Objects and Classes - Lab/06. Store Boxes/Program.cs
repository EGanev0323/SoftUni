using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> boxes = Console.ReadLine().Split().ToList();
            string input =Console.ReadLine();
            while (input!="end")
            {
                string[] tokens = input.Split();
                BoxAdd(boxes, tokens);
                boxes = boxes.OrderByDescending(b => b.PriceForABox).ToList();
            }
        }

        private static void BoxAdd(List<string> boxes, string[] tokens)
        {
            Item item = new Item();
            Box box = new Box();

            box.SeriaNumber = tokens[0];
            item.Name = tokens[1];
            box.ItemQuantity = int.Parse(tokens[2]);
            item.Price = decimal.Parse(tokens[3]);
            box.PriceForABox = box.ItemQuantity * item.Price;
            box.Items = item;
            boxes.Add(box);
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
    class Box
    {
        public string SeriaNumber { get; set; }
        public Item Items { get; set; }
        public int ItemQuantity{ get; set; }
        public decimal PriceForABox { get; set; }
    }
}
