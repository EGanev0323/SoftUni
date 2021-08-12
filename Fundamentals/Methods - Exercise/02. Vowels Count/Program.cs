using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(GetVowels(input));
        }
        public static int GetVowels(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    count++;
                }
                else if (input[i] == 'e')
                {
                    count++;
                }
                else if (input[i] == 'i')
                {
                    count++;
                }
                else if (input[i] == 'o')
                {
                    count++;
                }
                else if (input[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
