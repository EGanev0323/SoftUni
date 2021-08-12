using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("||");
            Dictionary<string, int> townPopulation = new Dictionary<string, int>();
            Dictionary<string, int> townGold = new Dictionary<string, int>();

            while (input[0] != "Sail")
            {
                string townName = input[0];
                int population = int.Parse(input[1]);
                int gold = int.Parse(input[2]);
                if (!townPopulation.ContainsKey(townName))
                {
                    townPopulation.Add(townName, 0);
                    townGold.Add(townName, 0);
                }

                townPopulation[townName] += population;
                townGold[townName] += gold;

                input = Console.ReadLine().Split("||");
            }

            string[] command = Console.ReadLine().Split("=>");
            while (command[0] != "End")
            {
                string town = command[1];
                switch (command[0])
                {
                    case "Plunder":
                        townPopulation[town] -= int.Parse(command[2]);
                        townGold[town] -= int.Parse(command[3]);
                        Console.WriteLine($"{town} plundered! {command[3]} gold stolen, {command[2]} citizens killed.");

                        if (townPopulation[town] <= 0 || townGold[town] <= 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            townPopulation.Remove(town);
                            townGold.Remove(town);
                        }
                        break;
                    case "Prosper":
                        if (int.Parse(command[2]) < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            townGold[town] += int.Parse(command[2]);
                            Console.WriteLine($"{command[2]} gold added to the city treasury. {town} now has {townGold[town]} gold.");
                        }

                        break;

                }

                command = Console.ReadLine().Split("=>");
            }

            if (townPopulation.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {townPopulation.Count} wealthy settlements to go to:");
                foreach (var item in townGold.OrderByDescending(x => x.Value).ThenBy(x => x))
                {
                    Console.WriteLine($"{item.Key} -> Population: {townPopulation[item.Key]} citizens, Gold: {item.Value} kg");
                }
            }
        }
    }
}
