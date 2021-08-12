using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Read the input- the totalNumOfClients
            int numOfClient = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            //2 For loop each client
            for (int i = 0; i < numOfClient; i++)
            {
                //2.1 While loop for the purchases of each client
                //2.2 Keep track of the total price
                double currentTotal = 0;
                int countOfItems = 0;
                string purchase = Console.ReadLine();
                while (purchase != "Finish")
                {
                    countOfItems++;
                    if (purchase == "basket")
                    {
                        currentTotal += 1.50;
                    }
                    else if (purchase == "wreath")
                    {
                        currentTotal += 3.80;
                    }
                    else if (purchase == "chocolate bunny")
                    {
                        currentTotal += 7;
                    }
                    purchase = Console.ReadLine();
                }
                if (countOfItems % 2 == 0)
                {
                    currentTotal -= currentTotal * 0.20;
                }
                totalPrice += currentTotal;
                Console.WriteLine($"You purchased {countOfItems} items for {currentTotal:f2} leva.");
                //3 Check if the num of items are even-> if yes 20%off
            }
            Console.WriteLine($"Average bill per client is: {totalPrice / numOfClient:f2} leva.");


            //Second method

           // int clients = int.Parse(Console.ReadLine());
            //double midSum = 0;
            //int productCount = 0;
            //double totalSumPerClient = 0;
            //for (int i = 0; i < clients; i++)
            //{
            //    string product = Console.ReadLine();
            //    while (product != "Finish")
            //    {
            //        productCount++;
            //        switch (product)
            //        {
            //            case "basket":
            //                midSum += 1.50;
            //                break;
            //            case "wreath":
            //                midSum += 3.80;
            //                break;
            //            case "chocolate bunny":
            //                midSum += 7;
            //                break;
            //        }
            //        product = Console.ReadLine();
            //    }

            //    if (productCount % 2 == 0)
            //    {
            //        midSum = midSum - midSum * 0.20;
            //    }
             //   totalSumPerClient += midSum;
             //   Console.WriteLine($"You purchased {productCount} items for {midSum:f2} leva.");
            //    midSum = 0;
            //    productCount = 0;
            //}

           // Console.WriteLine($"Average bill per client is: {totalSumPerClient / clients:f2} leva.");
        }
    }
}
