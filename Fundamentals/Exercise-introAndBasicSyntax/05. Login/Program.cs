using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string reversedUser = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                reversedUser += username[i];
            }

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                if (input == reversedUser)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (i==3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
                
        }
    }
}
