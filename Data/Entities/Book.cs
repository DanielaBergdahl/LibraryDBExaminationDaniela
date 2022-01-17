using LibraryDBExaminationDaniela.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDBExaminationDaniela.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } 
        public int Isbn { get; set; }
        public DateTime PublishingDate { get; set; }
        public int Rating { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

        public Book()
        {

        }
        //Funkar ej att köra programmet om jag har med constructor. Funkar bara utan 
        // och det funkar att göra POST medPostman utan constructor också.
        public Book(string title, int isbn, DateTime publishingDate, int rating)
        {
            Title = title;
            Isbn = isbn;
            PublishingDate = publishingDate;
            Rating = rating;
        }
    }
}
