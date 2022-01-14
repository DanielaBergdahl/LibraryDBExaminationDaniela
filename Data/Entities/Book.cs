using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDBExaminationDaniela.Data
{
    public class Book : BaseEntity
    {
        public int Book_id { get; set; }
        public string Title { get; set; } 
        public int Isbn { get; set; }
        public int PublishingDate { get; set; }
        public int Rating { get; set; }
    }
}
