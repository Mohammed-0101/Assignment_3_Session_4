using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Continue in Sheet Session 3
            #region 11.Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int copies = 100;
            object boxedCopies = copies;
            int unboxedCopies = (int)boxedCopies;
            Console.WriteLine(copies);
            Console.WriteLine(unboxedCopies);
            #endregion

            #region 12.Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".

            int pages = 464;

            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region 13.Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true. Use the && operator. 

            int pagges = 464;
            bool isAvailable = true;

            if (pagges > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region 14.Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            string title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region 15.Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel (same rule as question 8: long if pages > 300). 

            int pagees = 464;

            string sizeLabel = pagees > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);
            #endregion

            #region 16.Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1. Clean Code.

            string[] books =
            {
                "Clean Code",
                "The Pragmatic Programmer",
                "Refactoring"
            };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i]);
            }
            #endregion

            #region 17.Using the same books array, use a while loop to print every book title. 

            int counter = 0;

            while (counter < books.Length)
            {
                Console.WriteLine(books[counter]);
                counter++;
            }
            #endregion

            #region 18.Write a do-while loop that prints "Checking book..." exactly 3 times.

            int x = 0;

            do
            {
                Console.WriteLine("Checking book...");
                x++;
            }
            while (x < 3);
            #endregion

            #region 19.Using the same books array, use a foreach loop to print every book title. 

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion

            #region 20.Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring". 

            foreach (string book in books)
            {
                Console.WriteLine(book);

                if (book == "Refactoring")
                {
                    break;
                }
            }
            #endregion

            #region 21.Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }
            #endregion

            #region 22.Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty, use return to exit the method early instead of printing anything.

            PrintFirstBook(books);
            #endregion


            // String in Sheet Session 4

            #region 1-Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.

            string s_title = "clean code";

            string upperTitle = s_title.ToUpper();

            Console.WriteLine(s_title);
            Console.WriteLine(upperTitle);
            #endregion

            #region 2-Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.

            string title1 = "Clean Code";
            string title2 = "Clean Code";
            bool sameReference = object.ReferenceEquals(title1, title2);
            Console.WriteLine(sameReference);
            #endregion

            #region 3-Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object. Print the final result. 

            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            Console.WriteLine(sb.ToString());
            #endregion

            #region 4-Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.

            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());
            #endregion

            #region 5-Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator. 

            string C_title = "Clean Code";
            int p_pages = 464;
            Console.WriteLine("Book: " + C_title + ", Pages: " + p_pages);
            #endregion

            #region 6-Build the same sentence as above, but using string interpolation ($"...").

            string T_title = "Clean Code";
            Console.WriteLine($"Book: {T_title}, Pages: {pages}");
            #endregion




        }

        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }
    }
}
