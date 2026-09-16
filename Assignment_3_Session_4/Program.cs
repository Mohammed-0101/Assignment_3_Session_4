using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
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

            //Question 2

            #region  a) Identify at least three problems with this design from an encapsulation perspective.
            /*
             * 1- All fields are public
             * 2- There is no validation
             * 3- The internal data is exposed directly
             * 4- There is no control over how values are changed
             */
            #endregion

            #region  b) How can private fields and public properties improve this design? 
            // Private fields hide the internal data, while public properties provide a controlled way to access or modify it.
            #endregion

            // Smart Delivery Management System

            #region Create one DeliveryAddress value, copy it into a second variable, modify the copy, and print both values to prove that the original did not change.

           
            DeliveryAddress_S address1 = new DeliveryAddress_S("Cairo", "Tahrir Street", 10);

            DeliveryAddress_S address2 = address1;

            address2.City = "Alexandria";
            address2.Street = "Corniche Street";
            address2.BuildingNumber = 25;

            Console.WriteLine("Original Address:");
            Console.WriteLine(address1.GetFullAddress());

            Console.WriteLine("\nCopied and Modified Address:");
            Console.WriteLine(address2.GetFullAddress());
            #endregion

            #region  Smart Delivery Management System

            // a) Create a DeliveryCenter
            DeliveryCenter_S center = new DeliveryCenter_S();

            // b) Read data for three shipments
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Shipment {i + 1} Data");

                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine() ?? "";

                Console.Write("Description: ");
                string description = Console.ReadLine() ?? "";

                Console.Write("Weight: ");
                decimal weight = decimal.Parse(Console.ReadLine() ?? "0");

                Console.Write("Delivery Fee: ");
                decimal deliveryFee = decimal.Parse(Console.ReadLine() ?? "0");

                Console.Write("City: ");
                string city = Console.ReadLine() ?? "";

                Console.Write("Street: ");
                string street = Console.ReadLine() ?? "";

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine() ?? "0");

                // Create the address
                DeliveryAddress_S destination =
                    new DeliveryAddress_S(city, street, buildingNumber);

                // c) Create Shipment
                Shipment shipment = new Shipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    destination
                );

                // Add shipment to DeliveryCenter
                if (center.AddShipment(shipment))
                {
                    Console.WriteLine("\nShipment added successfully.");
                }
                else
                {
                    Console.WriteLine("\nDelivery center is full.");
                }

                Console.WriteLine();
            }

            // d) Print the three shipments using integer indexer
            Console.WriteLine("--- All Shipments ---");

            for (int i = 0; i < 3; i++)
            {
                Shipment shipment = center[i];

                Console.WriteLine($"--- Shipment {i + 1} ---");
                shipment.PrintShipment();
                Console.WriteLine();
            }

            // e) Ask user for tracking code
            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine() ?? "";

            // f) Search using string indexer
            Shipment foundShipment = center[searchCode];

            // g) Print shipment if found
            if (!string.IsNullOrWhiteSpace(foundShipment.TrackingCode))
            {
                Console.WriteLine(
                    $"Shipment found: {foundShipment.TrackingCode} - {foundShipment.Description}"
                );
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            // h) Demonstrate DeliveryAddress struct copy behavior
            Console.WriteLine();
            Console.WriteLine("--- Struct Copy Test ---");

            DeliveryAddress_S originalAddress = center[0].Destination;

            // Struct is copied by value
            DeliveryAddress_S copiedAddress = originalAddress;

            // Modify the copy
            copiedAddress.BuildingNumber = 20;
            copiedAddress.Street = "Makram Ebeid Street";

            Console.WriteLine(
                $"Original Address: {originalAddress.GetFullAddress()}"
            );

            Console.WriteLine(
                $"Copied Address: {copiedAddress.GetFullAddress()}"
            );
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
