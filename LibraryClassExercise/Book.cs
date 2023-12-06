using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassExercise
{
    internal class Book
    {
        public string title;
        public int pages;
        public string releaseDate;
        public string cover;
        public string ficOrNofic;
        public Author author;
        
        
        public Book(string Title, int Pages, string ReleaseDate, bool Cover, bool genre, Author authorInput)
        {
            title = Title;
            pages = Pages;
            releaseDate = ReleaseDate;
            if (Cover)
            {
                cover = "Hard Cover"; 
            }
            else 
            {
                cover = "Soft Cover"; 
            }
            if (genre) 
            {
                ficOrNofic = "Fiction";
            }
            else 
            { 
                ficOrNofic = "Non-Fiction"; 
            }
            
            authorInput = author;
        }
    }
}
