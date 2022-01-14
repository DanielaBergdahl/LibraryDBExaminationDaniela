using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDBExaminationDaniela.Data
{
    public class Borrower
    {
        public int Id { get; set; } //lånekortsnumret
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
