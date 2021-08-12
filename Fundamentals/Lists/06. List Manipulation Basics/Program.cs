using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }

                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int add = int.Parse(tokens[1]);
                        nums.Add(add);
                        break;
                    case "Remove":
                        int remove = int.Parse(tokens[1]);
                        nums.Remove(remove);
                        break;
                    case "RemoveAt":
                        int removeAt = int.Parse(tokens[1]);
                        nums.RemoveAt(removeAt);
                        break;
                    case "Insert":
                        int insertNum = int.Parse(tokens[1]);
                        int insertIndex = int.Parse(tokens[2]);
                        nums.Insert(insertIndex, insertNum);
                        break;

                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
