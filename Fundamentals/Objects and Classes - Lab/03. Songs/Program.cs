using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                Song song = new Song();
                song.TypeList = data[0];
                song.Name = data[1];
                song.Time = data[2];
                songs.Add(song);
            }
            string type =Console.ReadLine();
            if (type=="all")
            {
                foreach (var item in songs)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else 
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList==type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
