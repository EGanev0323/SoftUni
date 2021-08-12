using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string carName = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);
                cars.Add(carName, new int[] { mileage, fuel });
            }

            string command =Console.ReadLine();
            while (command!="Stop")
            {
                string[]splitted = command.Split(" : ");
                string cmd = splitted[0];
                if (cmd=="Drive")
                {
                    string carName = splitted[1];
                    int distance = int.Parse(splitted[2]);
                    int fuel = int.Parse(splitted[3]);
                    int []values = cars[carName];
                    if (fuel > values[1])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else if (fuel <= values[1])
                    {
                        cars[carName][0] += distance;
                        cars[carName][1] -= fuel;
                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                     if (values[0]>=100000)
                    {
                        cars.Remove(carName);
                        Console.WriteLine($"Time to sell the {carName}!");
                    }
                        
                }
                else if (cmd=="Refuel")
                {
                    string carName = splitted[1];
                    int fuel = int.Parse(splitted[2]);
                    int[] values = cars[carName];

                    if (values[1]+fuel>75)
                    {
                        Console.WriteLine($"{carName} refueled with {75-values[1]} liters");
                        cars[carName][1] = 75;

                    }
                    else
                    {
                        cars[carName][1] += fuel;
                        Console.WriteLine($"{carName} refueled with {fuel} liters");
                    }

                }
                else if (cmd=="Revert")
                {
                    string carName = splitted[1];
                    int kilometers = int.Parse(splitted[2]);
                    int[] values = cars[carName];

                    if (values[0]-kilometers<=10000)
                    {
                        cars[carName][0] = 10000;
                    }
                    else
                    {
                        cars[carName][0] -= kilometers;
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                }

                command =Console.ReadLine();
            }

            foreach (var item in cars.OrderByDescending(c=>c.Value[0]).ThenBy(c=>c.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }

        }
    }
}
