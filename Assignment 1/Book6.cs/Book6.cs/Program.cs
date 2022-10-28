using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public struct Book
{
    public int bookId;
    public string title;
    public float price;
    enum BookType
    {
        Magazine,
        Novel,
        ReferenceBook,
        Miscellaneous
    }
    public class Book6
    {
        public static void Output()
        {

            int n;
            int nobook = 1000;
            Book[] books = new Book[nobook];
            Console.WriteLine("enter the number of books you want to enter : ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\n\nInsert the information of books :\n");
            Console.Write("-----------------------------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the bookid->");
                books[i].bookId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the title->");
                books[i].title = Console.ReadLine();

                Console.WriteLine("enter the price->");
                books[i].price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input the type of book from the following list \r\n        Magazine,\r\n        Novel,\r\n        ReferenceBook,\r\n        Miscellaneous: ");
                Console.ReadLine();

            }
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}: bookId = {1}, Title = {2},price = {3},bookType={4}", i + 1, books[i].bookId, books[i].title, books[i].price);
                Console.WriteLine();
            }

        }
        public static void Main()
        {
            Book6.Output();
            Console.ReadKey();
        }

    }
}
