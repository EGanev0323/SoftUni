using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word =Console.ReadLine();
            string reversedWord = "";
            while (word!="end")
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }
                Console.WriteLine($"{word} = {reversedWord}");
                reversedWord = "";
                word =Console.ReadLine();
            }
        }
    }
}
