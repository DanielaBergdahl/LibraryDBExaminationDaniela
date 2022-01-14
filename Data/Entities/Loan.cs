using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDBExaminationDaniela.Data.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime DateReturned { get; set; }
        public int LibraryBookId { get; set; }
        public int BorrowerId { get; set; }
        public LibraryBook LibraryBook { get; set; }
        public Borrower Borrower { get; set; }
    }
}
