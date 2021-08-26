using System;
using System.Collections.Generic;
using BIBLIOTECA.Domain.Entities;

namespace BIBLIOTECA.Application.IRepositories
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetAll();
        public Book GetById(Guid id);
        public Book Create(Book book);
        public Book Update(Book book);
        public Guid Delete(Guid id);
    }
}
