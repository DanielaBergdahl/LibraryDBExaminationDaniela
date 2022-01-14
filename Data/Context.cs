using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDBExaminationDaniela.Areas.Identity.Data;
using LibraryDBExaminationDaniela.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryDBExaminationDaniela.Data
{
    public class Context : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Loan> Loans { get; set; } // När jag la till den här så fick jag error tills jag la till using LibraryDBExaminationDaniela.Data.Entities;
        public DbSet<LibraryBook> LibraryBooks { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

        public Context(DbContextOptions<Context> options) //vad behövs den här till?
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(sc => new { sc.BookId, sc.AuthorId });


            //base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
