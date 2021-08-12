using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            int failedTime = 0;
            int solveProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = " ";
            bool isFailed = true;

            while (failedTime < poorGrades)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTime++;
                }
                gradesSum += grade;
                solveProblemsCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solveProblemsCount:f2}");
                Console.WriteLine($"Number of problems: {solveProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

        }
    }
}
