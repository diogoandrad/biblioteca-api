using System;
using System.Collections.Generic;
using System.Linq;
using BIBLIOTECA.Infrastructure.DataContext;
using BIBLIOTECA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using BIBLIOTECA.Application.IRepositories;

namespace BIBLIOTECA.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
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

        public Book GetById(Guid id)
        {
            return _context.Books.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public Book Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public Book Update(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
            return book;
        }

        public Guid Delete(Guid id)
        {
            var book = GetById(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
            return id;
        }
    }
}
