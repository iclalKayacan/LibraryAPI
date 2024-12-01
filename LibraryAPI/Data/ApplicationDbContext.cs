using Microsoft.EntityFrameworkCore;
using OnlineLibraryAPI.Models;
using System.Collections.Generic;

namespace OnlineLibraryAPI.Data
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
