using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" : ").ToList();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (input[0]!="end")
            {
                string courseName = input[0];
                string name = input[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(name);
                input = Console.ReadLine().Split(" : ").ToList();
            }
            foreach (var item in courses.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var students in item.Value.OrderBy(s=>s))
                {
                    Console.WriteLine($"-- {String.Join(" ",students)}");
                }
            }
        }
    }
}
