using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
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

        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
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

            #region 7-Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.Call it and print pages afterward. How is the result different from question 5 ?
            int pages2 = 400;

            AddBonusPagesByRef(ref pages2);

            Console.WriteLine(pages2);
            //Because we using Passing or Calling By Reference
            #endregion

            #region 8-Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.

            double[] prices3 = { 25.5, 40.0 };

            ReplaceArray(ref prices3);

            Console.WriteLine(prices3.Length);
            #endregion

            // Sheet 5
            // Function Parameter Passing

            #region 1-Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it and print the price if found
            double price;

            bool found = TryGetPrice("Clean Code", out price);

            if (found)
            {
                Console.WriteLine("Price: " + price);
            }
            #endregion

            #region 2-Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.Call it once with only a title, and once passing both a title and pages.

            PrintBookInfo("Clean Code");
            Console.WriteLine();
            PrintBookInfo("The Pragmatic Programmer", 352);
            #endregion

            #region 3-Using the PrintBookInfo method from the question above, call it by naming the parameters, passing pages before title.
            PrintBookInfo(pages: 464, title: "Clean Code");
            #endregion

            #region 4-Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. Call it with three book titles.
            PrintAllTitles(
            "Clean Code",
            "The Pragmatic Programmer",
            "Design Patterns"
        );
            #endregion

            // Access Modifiers: 

            #region 1-Add a private string password = "secret"; field to a Book class. Try to print it from Main  (outside the class). What happens, and why?
            Book book = new Book();
            #endregion

        }

        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
        }
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}

class Book
{
    // Access Modifiers
    private string password = "secret";
    internal int copiesInStock = 5;
    public string Title;

    // Optional: method to access private field from inside the class
    public void PrintPassword()
    {
        Console.WriteLine(password);
    }
}
