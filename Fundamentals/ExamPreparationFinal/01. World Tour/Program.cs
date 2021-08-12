using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Travel")
            {
                string[] splitted = input.Split(":");

                if (splitted[0] == "Add Stop")
                {
                    int index = int.Parse(splitted[1]);
                    string insert = splitted[2];
                    if (destinations.Length > index)
                    {
                        destinations = destinations.Insert(index, insert);
                    }

                    Console.WriteLine(destinations);

                }
                else if (splitted[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(splitted[1]);
                    int endIndex = int.Parse(splitted[2]);
                    if (destinations.Length > startIndex && destinations.Length > endIndex)
                    {
                        destinations = destinations.Remove(startIndex, endIndex - startIndex + 1);
                    }

                    Console.WriteLine(destinations);
                }
                else if (splitted[0] == "Switch")
                {
                    string oldString = splitted[1];
                    string newString = splitted[2];
                    if (destinations.Contains(oldString))
                    {
                        destinations = destinations.Replace(oldString, newString);
                    }
                    Console.WriteLine(destinations);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
