using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Services
{
    public interface IBookService
    {
        public IEnumerable<Book> GetBooks();

        public Book GetById(Guid id);

        public Book AddBook(Book book);

        public Book UpdateBook(Guid id, Book book);

        public Guid DeleteBook(Guid id);
    }
}
