using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Read the input
            string name = Console.ReadLine();
            //2.Create a variable dor the score
            int score = 301;
            //3.Create two variable dor the succesfull and unnsuccesful shots
            int successfullShots = 0;
            int unsuccessfulShots = 0;
            string area = Console.ReadLine();
            //4.While loop until "Retire"
            while (area != "Retire")
            {
                //4.1 Read the info about the shot
                int points = int.Parse(Console.ReadLine());
                int currentPionts = 0;
                switch (area)
                {
                    case "Single":
                        currentPionts = points;
                        break;
                    case "Double":
                        currentPionts = points * 2;
                        break;
                    case "Triple":
                        currentPionts = points * 3;
                        break;
                }
                //Check the area and count the points
                //4.2 Check whether the shot was succesfull ot not
                //4.3 If succesfull->successfullShots++, score -=currentScore
                //4.4 Else> unsuccesfullShots++
                if (score - currentPionts >= 0)
                {
                    successfullShots++;
                    score -= currentPionts;
                }
                else
                {
                    unsuccessfulShots++;
                }

                //4.5 Chech if the person wins->break;
                if (score == 0)
                {
                    break;
                }
                area = Console.ReadLine();
            }
            if (area != "Retire")
            {
                Console.WriteLine($"{name} won the leg with {successfullShots} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {unsuccessfulShots} unsuccessful shots.");
            }
        }
    }
}
