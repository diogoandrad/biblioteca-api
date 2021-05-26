using Microsoft.EntityFrameworkCore;
using BIBLIOTECA.Domain.Entities;

namespace BIBLIOTECA.Infrastructure.DataContext
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
    }
}
