using System;

namespace _02._Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesTime = int.Parse(Console.ReadLine());
            int numOfScenes = int.Parse(Console.ReadLine());
            int sceneDuration = int.Parse(Console.ReadLine());
            double locationPrep = picturesTime * 0.15;
            double totalTimeForShooting = numOfScenes * sceneDuration;
            double totalTime = locationPrep + totalTimeForShooting;
            double difference = Math.Abs(picturesTime - totalTime);
            double roundedDifference = Math.Round(difference);

            if (picturesTime >= totalTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {roundedDifference} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {roundedDifference} minutes.");
            }
        }
    }
}
