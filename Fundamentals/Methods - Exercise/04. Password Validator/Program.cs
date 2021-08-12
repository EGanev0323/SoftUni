using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine().ToLower();
            if (BethweenNums(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (LettersAndDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (TwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (LettersAndDigits(password) && BethweenNums(password) && TwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        public static bool TwoDigits(string password)
        {
            int count = 0;
            foreach (var item in password)
            {
                if (item >= '0' && item <= '9')
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }
            return false;
        }

        public static bool BethweenNums(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }

        public static bool LettersAndDigits(string password)
        {
            bool isTrue = true;
            foreach (var item in password)
            {
                if (item >= 'a' && item <= 'z' || item >= '0' && item <= '9')
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }
            return isTrue;
        }
    }
}
