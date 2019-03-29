using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.classes
{
    public class Book
    {
        public string Title { get; set; }
        public string Genre { get; set; }
       
        //public string FavoriteGenre { get; set; }


        public enum Genres
        {
            Mystery,
            Horror,
            Comedy,
            Adventure,
            Romance,
            Action
        }
    }
}
