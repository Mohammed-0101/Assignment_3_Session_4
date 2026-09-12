using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Session_4
{
    internal class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        static void Main(string[] args)
        {
            // Sheet 4
            #region 1-Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).

            double[] prices1 = { 25.5, 40.0, 33.75 };

            Console.WriteLine("Question 1:");
            Console.WriteLine(prices1[1]);
            #endregion

            #region 2-Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.

            int[,] shelfCopies =
            {
                { 3, 5 },
                { 1, 4 }
            };

            Console.WriteLine("\nQuestion 2:");
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region 3-Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
            PrintWelcomeMessage();
            #endregion

            #region 4-Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            PrintBookTitle("Clean Code");
            #endregion

            #region 5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?

            int pages = 400;

            AddBonusPages(pages);

            Console.WriteLine(pages);

            // result = 400
            //Because int is the value type Therefore, the change only occurs on the copy.
            #endregion

            #region 6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?

            double[] prices2 = { 25.5, 40.0 };

            ApplyDiscount(prices2);

            Console.WriteLine(prices2[0]);

            // result=20.5
            // Because Array is Reference type
            #endregion


        }
    }
}
