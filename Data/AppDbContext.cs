using library_management_system__api.Models;
using Microsoft.EntityFrameworkCore;

namespace library_management_system__api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }

        public DbSet<Book> Books { get; set; }

    }
}
