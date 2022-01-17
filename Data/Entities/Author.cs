using LibraryDBExaminationDaniela.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDBExaminationDaniela.Data
{
    public class Author
    {
        //[Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

        //public Author()
        //{

        //}

        //public Author(string firstName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}
        //TODO - kanske lägg till list of Book books. Det är ett relationship.
    }
}
