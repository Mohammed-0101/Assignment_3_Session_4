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
        {
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
