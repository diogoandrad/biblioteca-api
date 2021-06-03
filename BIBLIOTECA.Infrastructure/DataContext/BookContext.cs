using Microsoft.EntityFrameworkCore;
using BIBLIOTECA.Domain.Entities;
using BIBLIOTECA.Infrastructure.Mappings;

namespace BIBLIOTECA.Infrastructure.DataContext
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookMap());
        }
    }
}
