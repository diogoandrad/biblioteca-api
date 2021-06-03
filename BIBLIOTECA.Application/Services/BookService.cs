using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BIBLIOTECA.Domain.Entities;
using BIBLIOTECA.Application.Interfaces;
using BIBLIOTECA.Infrastructure.DataContext;

namespace BIBLIOTECA.Application.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _context;

        public BookService(BookContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            var book = _context.Books.ToList();
            return book;
        }

        public Book GetById(Guid id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            return book;
        }

        public Book AddBook(Book book)
        {
            if (book != null)
            {
                book.Id = Guid.NewGuid();
                _context.Books.Add(book);
                _context.SaveChanges();
                return book;
            }
            return null;
        }

        public Book UpdateBook(Guid id, Book book)
        {
            book.Id = id;
            _context.Books.Update(book);
            _context.SaveChanges();
            return book;
        }

        public Guid DeleteBook(Guid id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Entry(book).State = EntityState.Deleted;
            _context.SaveChanges();
            return id;
        }
    }
}
