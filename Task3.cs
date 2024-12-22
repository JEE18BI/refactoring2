using System;

namespace CodeRefactoring
{
    /// <summary>
    /// In this task, Let's imagine we have two systems one for managing an online bookstore and the other 
    /// for a library. We currently have a single class called Book that handles all the functionality 
    /// related to books. However, it's better to separate concerns and create separate classes for different
    /// responsibilities. The task includes extracting classes to handle specific responsibilities, such as 
    /// managing books in the bookstore and managing books in the library.
    /// This task covers:
    /// 1. Extract Class
    /// 2. Extract Super Class
    /// 3. Extract Methods
    /// </summary>

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }
        public int Year { get; set; }

        public void SellBook(int quantity)
        {
            if (quantity <= Quantity)
            {
                Quantity -= quantity;
                Console.WriteLine($"Sold {quantity} copies of {Title}.");
            }
            else
            {
                Console.WriteLine($"Insufficient stock for {Title}.");
            }
        }

        public void RestockBook(int quantity)
        {
            Quantity += quantity;
            Console.WriteLine($"Restocked {quantity} copies of {Title}.");
        }

        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"You have borrowed {Title} by {Author}.");
            }
            else
            {
                Console.WriteLine($"{Title} is not available for borrowing.");
            }
        }

        public void ReturnBook()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"You have returned {Title} by {Author}.");
            }
            else
            {
                Console.WriteLine($"{Title} is already available.");
            }
        }
    }

    public class BookStoreItemManager : Book
    {
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Quantity: {Quantity}");
        }
    }

    public class LibraryItemManager : Book
    {
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
        }
    }
}
