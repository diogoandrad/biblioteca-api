using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BIBLIOTECA.API.Models;

namespace BIBLIOTECA.API.Services
{
    public class BookService : IBookService
    {
        BookContext dbContext;

        public BookService(BookContext _bookItems)
        {
            dbContext = _bookItems;
        }

        public IEnumerable<Book> GetBooks()
        {
            var book = dbContext.Books.ToList();
            return book;
        }

        public Book GetById(Guid id)
        {
            var book = dbContext.Books.FirstOrDefault(x => x.Id == id);
            return book;
        }

        public Book AddBook(Book book)
        {
            if (book != null)
            {
                book.Id = Guid.NewGuid();
                dbContext.Books.Add(book);
                dbContext.SaveChanges();
                return book;
            }
            return null;
        }

        public Book UpdateBook(Guid id, Book book)
        {
            book.Id = id;
            dbContext.Books.Update(book);
            dbContext.SaveChanges();
            return book;
        }

        public Guid DeleteBook(Guid id)
        {
            var book = dbContext.Books.FirstOrDefault(x => x.Id == id);
            dbContext.Entry(book).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return id;
        }
    }
}
