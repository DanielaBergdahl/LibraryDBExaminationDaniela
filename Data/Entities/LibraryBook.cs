using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDBExaminationDaniela.Data.Entities
{
    public class LibraryBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public bool Borrowed { get; set; }
        public Book Book { get; set; }
    }
}
