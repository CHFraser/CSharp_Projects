using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    internal class Program
    {
        // interface class INVENTORY
        public interface IInventory
        {
            void ReceiveStock(int arg);
            void SellStock(int arg);
            string ScanCode();
        }
        // abstract class (cannot be instantiated directly) PRODUCT
        public abstract class Product : IInventory
        {
            // data elements for Product class
            protected string partNumber;
            protected decimal price;
            protected int countCurrentStock;
            protected int countSold;

            // default constructor
            public Product() { }

            // constructor that populates all data elements
            public Product(string pNumber, decimal pPrice, int cCStock, int cSold) 
            {
                partNumber = pNumber;
                price = pPrice;
                countCurrentStock = cCStock;
                countSold = cSold;
            }

            public void ReceiveStock(int arg) 
            {
                countCurrentStock += arg;
            }

            public void SellStock(int arg)
            {
                countCurrentStock -= arg;
                countSold += arg;
                
            }

            public string ScanCode() { return partNumber; }

           
        }
        // BOOK Class
        public class Book : Product
        {
            private string ISBNNumber;
            private string title;
            private int countPages;

            //default
            public Book() { }

            //constructor that populates all the book data members
            public Book(string pNumber , decimal pPrice, int cCStock, int cSold, string iNumber, string pTitle, int cPages) :base(pNumber, pPrice, cCStock, cSold)
            {
                ISBNNumber = iNumber;
                title = pTitle;
                countPages = cPages;
            }

            // ToString() Override Method
            public override string ToString()
            {
                return "Book: " + ISBNNumber + "\n" +
                       "Title: " + title + "\n" +
                       "Pages: " + countPages + "\n" +
                       "PN: " + partNumber + "\n" +
                       "Price: " + price + "\n" +
                       "In Stock: " + countCurrentStock + "\n" +
                       "Sold: " + countSold;


            }

            public string ScanCode()
            {
                return ISBNNumber;
            }      
        }

        // TOY Class
        public class Toy : Product
        {
            private string name;
            private int ageMinimum;

            public Toy() { }

            public Toy( string partNumber, decimal pPrice, int cCStock, int cSold, string pName, int pAgeMinimum) :base(partNumber, pPrice, cCStock,cSold)
            {
                name = pName;
                ageMinimum = pAgeMinimum;
            }

            public override string ToString()
            {
                return  "Toy: " + name + "\n" +  
                        "Age: " + ageMinimum + "\n" +
                        "PN: " + partNumber + "\n" +
                        "Price: " + price + "\n" +
                        "In Stock: " + countCurrentStock + "\n" +
                        "Sold: " + countSold;
            }

            public string ScanCode()
            {
                return partNumber;
            }


        }
        class MainClass
        {
            // instead of repeating this, make a method.
            public static string Divider()
            {
                return "--------------------------";
            }
            // this is the main program
            public static void Main(string[] args)
            {
                Console.WriteLine(Divider());
                Console.WriteLine("Book");
                Console.WriteLine(Divider());
                Book newBook = new Book("123", 45.99M, 10, 0, "0345400771", "Star Wars", 260);
                Console.WriteLine(newBook);
                newBook.ReceiveStock(40);
                newBook.SellStock(1);
                Console.WriteLine(Divider());
                Console.WriteLine(newBook.ScanCode());
                Console.WriteLine(Divider());
                Console.WriteLine(newBook);
                Console.WriteLine(Divider());
                Console.WriteLine("Toy");
                Console.WriteLine(Divider());
                Toy newToy = new Toy("456", 5.99M, 20, 0, "Han Solo Action Figure", 4);
                Console.WriteLine(newToy);
                newToy.ReceiveStock(10);
                newToy.SellStock(3);
                Console.WriteLine(Divider());
                Console.WriteLine(newToy.ScanCode());
                Console.WriteLine(Divider());
                Console.WriteLine(newToy);
                Console.WriteLine(Divider());
            }
        }
        
    }
}
