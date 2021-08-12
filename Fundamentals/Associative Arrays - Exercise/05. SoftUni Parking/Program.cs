using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, string> carRegister = new Dictionary<string, string>();
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string username = input[1];
                //string licensePlate = input[2];
                switch (command)
                {
                    case "register":
                        Register(carRegister, input, username);
                        break;
                    case "unregister":
                        Unregister(carRegister, username);
                        break;
                }
            }

            foreach (var item in carRegister)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        private static void Register(Dictionary<string, string> carRegister, string[] input, string username)
        {
            if (!carRegister.ContainsKey(username))
            {
                carRegister.Add(username, input[2]);
                Console.WriteLine($"{username} registered {input[2]} successfully");
            }
            else if(carRegister.ContainsValue(input[2]))
            {
                Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
            }
        }


        private static void Unregister(Dictionary<string, string> carRegister, string username)
        {
            if (carRegister.ContainsKey(username))
            {
                carRegister.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
        }

       
    }
}
