using System;
using System.Collections.Generic;
using BIBLIOTECA.Domain.Entities;
using BIBLIOTECA.Application.IRepositories;

namespace BIBLIOTECA.Application.Services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetById(Guid id)
        {
            return _bookRepository.GetById(id);
        }

        public Book Create(Book book)
        {
            return _bookRepository.Create(book);
        }

        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }

        public Guid Delete(Guid id)
        {
            return _bookRepository.Delete(id);
        }
    }
}
