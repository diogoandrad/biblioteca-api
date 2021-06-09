using System;
using System.Collections.Generic;
using BIBLIOTECA.Domain.Entities;

namespace BIBLIOTECA.Application.Interfaces
{
    public interface IBookService
    {
        public IEnumerable<Book> GetAll();
        public Book GetById(Guid id);
        public Book Create(Book book);
        public Book Update(Guid id, Book book);
        public Guid Delete(Guid id);
    }
}
