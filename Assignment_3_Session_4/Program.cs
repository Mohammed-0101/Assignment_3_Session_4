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
            #region Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int copies = 100;
            object boxedCopies = copies;
            int unboxedCopies = (int)boxedCopies;
            Console.WriteLine(copies);
            Console.WriteLine(unboxedCopies);
            #endregion

        }
    }
}
