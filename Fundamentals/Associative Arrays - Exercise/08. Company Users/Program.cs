using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" -> ").ToList();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (input[0]!="End")
            {
                string companyName = input[0];
                string employeeId = input[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeId);
                }
                else if (!companies[companyName].Contains(employeeId))
                {
                    companies[companyName].Add(employeeId);
                }
                
                input = Console.ReadLine().Split(" -> ").ToList();
            }

            foreach (var item in companies.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var employees in item.Value)
                {
                    Console.WriteLine($"-- {string.Join("",employees)}");
                }
            }
        }
    }
}
