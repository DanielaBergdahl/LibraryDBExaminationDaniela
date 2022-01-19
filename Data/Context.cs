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
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LibraryBook> LibraryBooks { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(sc => new { sc.BookId, sc.AuthorId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(sc => sc.Book)
                .WithMany(s => s.BookAuthors)
                .HasForeignKey(sc => sc.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(sc => sc.Author)
                .WithMany(c => c.BookAuthors)
                .HasForeignKey(sc => sc.AuthorId);
        }
    }
}
