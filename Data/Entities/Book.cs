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
        public int Id { get; set; }
        public string Title { get; set; } 
        public int Isbn { get; set; }
        public DateTime PublishingDate { get; set; }
        public int Rating { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
