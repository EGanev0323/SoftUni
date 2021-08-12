using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string games = Console.ReadLine();
            string winOrLoos =" ";
            int earnedMoney = 0;
            double totalMoney = 0;
            int winGamesForDay = 0;
            int totalWins = 0;
            int totalLoose = 0;
            int lostGamesForDay = 0;
            for (int i = 1; i <= days; i++)
            {
                while (games != "Finish")
                {
                    winOrLoos = Console.ReadLine();
                    if (winOrLoos == "win")
                    {
                        earnedMoney += 20;
                        winGamesForDay++;
                    }
                    else
                    {
                        lostGamesForDay++;
                    }
                    games = Console.ReadLine();
                    
                }
                totalWins = winGamesForDay;
                totalLoose = lostGamesForDay;
            }

            if (winGamesForDay > lostGamesForDay)
            {
                totalMoney = earnedMoney + earnedMoney * 0.1;
            }
            else
            {
                totalMoney = earnedMoney;
            }
            if (totalWins>totalLoose)
            {
                totalMoney = earnedMoney + earnedMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                totalMoney = totalMoney;
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
           
        }
    }
}
