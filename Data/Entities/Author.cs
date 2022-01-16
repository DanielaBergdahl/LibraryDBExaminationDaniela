using LibraryDBExaminationDaniela.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDBExaminationDaniela.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

        //TODO - lägg till list of Book books. Det är ett relationship. KANSKE vi får se
    }
}
