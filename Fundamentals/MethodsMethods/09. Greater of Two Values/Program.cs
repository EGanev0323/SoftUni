using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstNum =Console.ReadLine();
            string secondNum = Console.ReadLine();
            if (type=="int")
            {
                int intFirst = int.Parse(firstNum);
                int intSecond = int.Parse(secondNum);
                Console.WriteLine(GetMax(intFirst,intSecond));
            }
            else if (type=="char")
            {
                char charFirst = char.Parse(firstNum);
                char charSecond = char.Parse(secondNum);
                Console.WriteLine((char)GetMax(charFirst,charSecond));
            }
            else if (type=="string")
            {
                string result = GetMax(firstNum, secondNum);
                Console.WriteLine(result);
            }
        }

         static string GetMax(string firstNum, string secondNum)
        {
            int firstSum =  SumOfStrigns(firstNum);
            int secondSum = SumOfStrigns(secondNum);
            if (firstSum>secondSum)
            {
                return firstNum;
            }

            return secondNum;
        }

        static int GetMax(int intFirst, int intSecond)
        {
            if (intFirst>intSecond)
            {
                return intFirst;
            }

            return intSecond;
        }

        static int SumOfStrigns(string value)
        {
            int sumValue = 0;
            for (int i = 0; i < value.Length; i++)
            {
                sumValue += value[i];
            }

            return sumValue;
        }
    }
}
