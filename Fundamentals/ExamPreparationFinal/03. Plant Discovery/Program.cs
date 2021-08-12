using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> plants = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantsRating = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string name = input[0];
                int rarity = int.Parse(input[1]);
                if (!plants.ContainsKey(name))
                {
                    plants.Add(name, rarity);
                    plantsRating.Add(name, new List<double>());
                }
                plants[name] = rarity;

            }

            string command = Console.ReadLine();
            string[] splitted = command.Split();
            while (command != "Exhibition")
            {
                splitted = command.Split();
                if (splitted[0] == "Rate:")
                {
                    string name = splitted[1];
                    double rating = double.Parse(splitted[3]);
                    plantsRating[name].Add(rating);
                }
                else if (splitted[0] == "Update:")
                {
                    string name = splitted[1];
                    int rarity = int.Parse(splitted[3]);
                    plants[name] = rarity;
                }
                else if (splitted[0] == "Reset:")
                {
                    string name = splitted[1];
                    plantsRating[name] = new List<double> { 0.0};
                }
                else
                {
                    Console.WriteLine("error");
                }
                command =Console.ReadLine(); 
            }

           
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants.OrderByDescending(p=>p.Value))
            {
                List<double> ratings = plantsRating[item.Key];
                
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: {ratings.Average():f2}");

            }
        }


    }
}
