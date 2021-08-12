using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] data = input.Split(" | ");
                    if (!forceBook.ContainsKey(data[0]))
                    {
                        forceBook.Add(data[0], new List<string>());
                    }
                    forceBook[data[0]].Add(data[1]);
                }
                else if (input.Contains("->"))
                {
                    string[] data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (!forceBook.Values.Any(x => x.Contains(data[0])))
                    {
                        if (!forceBook.ContainsKey(data[1]))
                        {
                            forceBook.Add(data[1], new List<string>());
                        }

                        forceBook[data[2]].Add(data[0]);
                        Console.WriteLine($"{data[1]} joins the {data[0]} side!");
                    }
                    else
                    {
                        foreach (var item in forceBook)
                        {
                            if (item.Value.Contains(data[0]))
                            {
                                item.Value.Remove(data[0]);
                            }

                        }
                        if (!forceBook.ContainsKey(data[1]))
                        {
                            forceBook.Add(data[1], new List<string>());
                        }
                        forceBook[data[1]].Add(data[0]);
                        Console.WriteLine($"{input[2]} joins the {input[0]} side!");
                    }
                }


                input = Console.ReadLine();
            }

            forceBook = forceBook.OrderByDescending(u => u.Value.Count).ThenBy(s => s.Key).ToDictionary(s => s.Key, ul => ul.Value);
            foreach (var item in forceBook)
            {
                item.Value.Sort();
                if (item.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine(string.Join($"\n! ", item.Value));
                }
            }
        }
    }
}
