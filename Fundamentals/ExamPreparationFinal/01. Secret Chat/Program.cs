using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Reveal")
            {
                string[] splitted = input.Split(":|:");
                string command = splitted[0];
                if (command == "InsertSpace")
                {
                    int index = int.Parse(splitted[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substring = splitted[1];
                    if (message.Contains(substring))
                    {
                       
                        for (int i = substring.Length - 1; i > -1; i--)
                        {
                            message += substring[i];
                        }

                        int startIndex = message.IndexOf(substring);
                        message = message.Remove(startIndex, substring.Length);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }


                }
                else if (command=="ChangeAll")
                {
                    string substring = splitted[1];
                    string replacement = splitted[2];

                    message = message.Replace(substring,replacement);
                    Console.WriteLine(message);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
