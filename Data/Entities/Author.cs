using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDBExaminationDaniela.Data
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //TODO - lägg till list of Book books. Det är ett relationship.
    }
}
