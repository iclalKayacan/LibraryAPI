using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using LibraryAPI.Models;
using System.Collections.Generic;

namespace LibraryAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
