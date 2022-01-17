using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDBExaminationDaniela.Data.Entities
{
    public class BookAuthor
    {
        //TODO - The entity type 'BookAuthor' requires a primary key to be defined.
        //Ska nog göras i Context?
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }

        //public BookAuthor()
        //{

        //}
        //public BookAuthor(Book book, Author author)
        //{
        //    Book = book;
        //    Author = author;
        //}
    
    }
}
