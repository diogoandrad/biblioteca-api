using System;
using System.Collections.Generic;
using System.Linq;
using BIBLIOTECA.Infrastructure.DataContext;
using BIBLIOTECA.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BIBLIOTECA.Infrastructure.Repositories
{
    public class BookRepository
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.AsNoTracking().ToList();
        }

        public virtual Book GetById(Guid id)
        {
            return _context.Books.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public Book Create(Book book)
        {
            book.Id = Guid.NewGuid();
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public Book Update(Guid id, Book book)
        {
            book.Id = id;
            _context.Books.Update(book);
            _context.SaveChanges();
            return book;
        }

        public Guid Delete(Guid id)
        {
            var book = GetById(id);
            _context.Set<Book>().Remove(book);
            _context.SaveChanges();
            return id;
        }
    }
}
