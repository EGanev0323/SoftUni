using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxNumOfEggs = int.MinValue;
            string maxNumOfEggsColor = String.Empty;

            for (int i = 0; i < eggs; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        redEggs++;
                        if (redEggs > maxNumOfEggs)
                        {
                            maxNumOfEggs = redEggs;
                            maxNumOfEggsColor = "red";
                        }
                        break;
                    case "orange":
                        orangeEggs++;
                        if (orangeEggs > maxNumOfEggs)
                        {
                            maxNumOfEggs = orangeEggs;
                            maxNumOfEggsColor = "orange";
                        }
                        break;
                    case "blue":
                        blueEggs++;
                        if (blueEggs > maxNumOfEggs)
                        {
                            maxNumOfEggs = blueEggs;
                            maxNumOfEggsColor = "blue";
                        }
                        break;
                    case "green":
                        greenEggs++;
                        if (greenEggs > maxNumOfEggs)
                        {
                            maxNumOfEggs = greenEggs;
                            maxNumOfEggsColor = "green";
                        }
                        break;

                }
            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxNumOfEggs} -> {maxNumOfEggsColor}");

        }
    }
}
