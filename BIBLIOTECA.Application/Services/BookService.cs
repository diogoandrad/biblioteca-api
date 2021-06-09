using System;
using System.Collections.Generic;
using BIBLIOTECA.Domain.Entities;
using BIBLIOTECA.Application.Interfaces;
using BIBLIOTECA.Infrastructure.DataContext;
using BIBLIOTECA.Infrastructure.Repositories;

namespace BIBLIOTECA.Application.Services
{
    public class BookService : IBookService
    {
        private readonly BookRepository _bookRepository;

        public BookService(BookContext context)
        {
            _bookRepository = new BookRepository(context);
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

        public Book Update(Guid id, Book book)
        {
            return _bookRepository.Update(id, book);
        }

        public Guid Delete(Guid id)
        {
            return _bookRepository.Delete(id);
        }
    }
}
