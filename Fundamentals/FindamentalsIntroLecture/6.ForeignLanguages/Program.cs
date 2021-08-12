using System;

namespace _6.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string coutry =Console.ReadLine();
            switch (coutry)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Argentina":
                case "Mexico":
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
