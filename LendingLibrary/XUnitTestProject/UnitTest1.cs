using System;
using Xunit;
using System.Collections.Generic;
using System.Collections;
using LendingLibrary.classes;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddBooksToALibrary()
        {

            Library<Book> Library = new Library<Book> {

                new Book {Title = "The Hunger Games", Genre = "Action" },
                new Book {Title = "50 Shades", Genre = "Romance" },
                new Book {Title = "Killers", Genre = "Horror" },
                new Book {Title = "The Remaining", Genre = "Adventure" },
                new Book {Title = "Blues Clues", Genre = "Mystery" },
                new Book { Title = "Click", Genre = "Comedy" }
                };
            int count = Library.Count();
            Assert.Equal(6, count);





        }
        //[Theory ]
        [Fact]
        public void CanCorrectlyCount()
        {
            Library<Book> Library = new Library<Book> {

                new Book {Title = "The Hunger Games", Genre = "Action" },
                new Book {Title = "50 Shades", Genre = "Romance" },
                new Book {Title = "Killers", Genre = "Horror" },
                new Book {Title = "The Remaining", Genre = "Adventure" },
                new Book {Title = "The Jungle Book", Genre = "Adventure" },
                new Book {Title = "The One Eyed", Genre = "Adventure" },
                new Book {Title = "Blues Clues", Genre = "Mystery" },
                new Book {Title = "Click", Genre = "Comedy" }
                };
            int count = Library.Count();
            Assert.Equal(8, count);

        }
    }
}

