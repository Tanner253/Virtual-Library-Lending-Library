﻿using System;
using System.Collections.Generic;
using System.Collections;
using LendingLibrary.classes;
namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Phil's Library");
            Library<Book> allBooks = InitTheLibrary();
            Console.WriteLine("These are all of the books in the library");
            Console.WriteLine("-----------------------");
            Borrow(allBooks);
            Console.ReadKey();
        }


        static Library<Book> InitTheLibrary()
        {
            Library<Book> Library = new Library<Book>
            {
                new Book {Title = "The Hunger Games", Genre = "Action" },
                new Book {Title = "50 Shades", Genre = "Romance" },
                new Book {Title = "Killers", Genre = "Horror" },
                new Book {Title = "The Remaining", Genre = "Adventure" },
                new Book {Title = "Blues Clues", Genre = "Mystery" },
                new Book {Title = "Click", Genre = "Comedy" }
            };
            return Library;
           

        }
        static void Borrow(Library<Book> libraryBooks)
        {
            Library<string> userLibrary1 = new Library<string>();
            foreach (var value in libraryBooks)
            {

                Console.WriteLine($"Title: {value.Title}");
                Console.WriteLine($"Genre: {value.Genre}");
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Choose one of the books to add to your personal Library");
            string bookTitle = Console.ReadLine();
            userLibrary1.Add(bookTitle);
            Console.WriteLine("Choose Another book to add to your personal Library");
            string bookTitle2 = Console.ReadLine();
            userLibrary1.Add(bookTitle2);
            Console.WriteLine();
            Console.WriteLine($"This is how many books you saved: { userLibrary1.Count()}");
        }
    }
}
