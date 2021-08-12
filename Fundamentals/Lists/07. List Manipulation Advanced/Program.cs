using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = nums.ToList();

            bool changesMade = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    
                    break;
                }

                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int add = int.Parse(tokens[1]);
                        newList.Add(add);
                        changesMade = true;
                        break;
                    case "Remove":
                        int remove = int.Parse(tokens[1]);
                        newList.Remove(remove);
                        changesMade = true;
                        break;
                    case "RemoveAt":
                        int removeAt = int.Parse(tokens[1]);
                        newList.RemoveAt(removeAt);
                        changesMade = true;
                        break;
                    case "Insert":
                        int insertNum = int.Parse(tokens[1]);
                        int insertIndex = int.Parse(tokens[2]);
                        newList.Insert(insertIndex, insertNum);
                        changesMade = true;
                        break;
                    case "Contains":
                        int num = int.Parse(tokens[1]);
                        if (newList.Contains(num) == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;
                    case "PrintEven":
                        PrintEven(newList);
                        break;
                    case "PrintOdd":
                        PrintOdd(newList);
                        break;
                    case "GetSum":
                        Console.WriteLine(newList.Sum());
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int number = int.Parse(tokens[2]);
                        Filter(condition, number, newList);
                        break;
                }

            }

            if (newList != nums && changesMade)
            {
                Console.WriteLine(string.Join(" ", newList));
            }
        }

        private static void Filter(string condition, int number, List<int> newList)
        {
            if (condition == "<")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (number > newList[i])
                    {
                        Console.Write(newList[i] + " ");
                    }

                }

                Console.WriteLine();
            }
            else if (condition == ">")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (number < newList[i])
                    {
                        Console.Write(newList[i] + " ");
                    }

                }

                Console.WriteLine();
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (number <= newList[i])
                    {
                        Console.Write(newList[i] + " ");
                    }

                }

                Console.WriteLine();
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (number >= newList[i])
                    {
                        Console.Write(newList[i] + " ");
                    }

                }

                Console.WriteLine();
            }
        }

        private static void PrintOdd(List<int> newList)
        {
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] % 2 == 1)
                {
                    Console.Write(newList[i] + " ");
                }

            }

            Console.WriteLine();
        }

        private static void PrintEven(List<int> newList)
        {
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] % 2 == 0)
                {
                    Console.Write(newList[i] + " ");
                }

            }

            Console.WriteLine();
        }
    }
}
