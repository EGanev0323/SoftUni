using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (var item in usernames)
            {
                if (IsValid(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        static bool IsValid(string usernames)
        {
            bool isValidUser = true;
            foreach (var item in usernames)
            {

                if ((item == ('-') || item == ('_') || char.IsLetterOrDigit(item))&&usernames.Length >= 3 && usernames.Length <= 16)
                {
                        isValidUser = true;
                }
                else
                {
                    isValidUser = false;
                    break;
                }
            }


            return isValidUser;
        }


    }
}
