using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using LendingLibrary.classes;

namespace LendingLibrary.classes
{
    public class Library<T> : IEnumerable
    {
        T[] books = new T[10];
        int count = 0;
        public void Add(T book)
        {
            if(count == books.Length)
            {
                Array.Resize(ref books, (books.Length * 2));
            }
            books[count++] = book;
        }

        //public void Remove(T number)
        //see demo for start and finish

        /*public void Remove(string title, Library<Book> library)
        {
            for (int i = 0; i < library.Count(); i++)
            {
                if(title == library[i])
                {

                }
            }
        }*/
        public int Count()
        {
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
