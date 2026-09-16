using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Session_4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Sheet 5
            #region 4-Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,  assign it Genre.Science, and print it.
            Book book = new Book();

            book.Title = "C# Programming";
            book.Genre = Genre.Science;

            Console.WriteLine("Question 4:");
            Console.WriteLine(book.Genre);

            #endregion

            #region 5-Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.

            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion

            #region 6-Given int genreNumber = 1;, cast it into a Genre value and print the result.  

            int genreNumber = 1;

            Genre genreFromNumber = (Genre)genreNumber;

            Console.WriteLine(genreFromNumber);
            #endregion

            #region 7-Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and print the result. 

            string genreText = "Science";

            var genreFromText =Enum.Parse(typeof(Genre), genreText);

            Console.WriteLine(genreFromText);
            #endregion

            #region 8-Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to attempt the conversion. Print "Unknown genre" if it fails.

            string invalidGenreText = "Mystery";

            if (Enum.TryParse(invalidGenreText, out Genre parsedGenre))
            {
                Console.WriteLine(parsedGenre);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion


            //C# OOP Assignment 
            /*
            OOP 01 - Smart Delivery Management System 
            Part 01 : Theoretical Questions 
            */
            #region (A) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //answer a:
            //The entire struct value is copied. The two variables are independent, so changes to the copy do not affect the original.
            //because it is the value type
            #endregion

            #region b)  What happens when a Customer variable is copied into another variable and one variable modifies the object
            //answer b:
            //The reference is copied, so both variables refer to the same Customer object. Modifying the object through either variable is visible through the other.
            #endregion
        }
    }
}



enum Genre
{
Fiction,
NonFiction,
Science
}

class Book
{
private string password = "123";
internal int copiesInStock = 5;
public string Title;
public Genre Genre;

}
