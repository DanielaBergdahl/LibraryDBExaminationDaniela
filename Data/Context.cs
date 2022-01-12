using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDBExaminationDaniela.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryDBExaminationDaniela.Data
{
    public class Context : DbContext
    {
        public DbSet<Book> Books { get; set; } //TODO - Ändra till Book.Eller ändra de andra till plural?
        public DbSet<Author> Author { get; set; }
        public DbSet<Borrower> Borrower { get; set; }
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
