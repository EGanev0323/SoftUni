using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedWord =Console.ReadLine();
            string word =Console.ReadLine();

            while (word.Contains(searchedWord))
            {
                int index = word.IndexOf(searchedWord);
                word=word.Remove(word.IndexOf(searchedWord), searchedWord.Length);
            }
            Console.WriteLine(word);
        }
    }
}
