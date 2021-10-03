using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songsNames = new Queue<string>();
            foreach (var item in songs)
            {
                songsNames.Enqueue(item);
            }
            string command =Console.ReadLine();

            while (songsNames.Count!=0)
            {
                int indexSeparator = command.IndexOf(' ');
                string[] splitted = command.Split();

                string cmd = splitted[0];
                if (cmd=="Add")
                {

                    //string fullName = "";
                    //for (int i = 1; i < splitted.Length; i++)
                    //{
                    //     fullName += splitted[i] + " ";
                    //}

                    string songToAdd = command.Substring(indexSeparator + 1);
                    if (!songsNames.Contains(songToAdd))
                    {
                        songsNames.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }

                }
                else if (cmd=="Play")
                {
                    songsNames.Dequeue();
                }
                else if (cmd=="Show")
                {
                    Console.WriteLine(string.Join(", ", songsNames));
                }
                command =Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
