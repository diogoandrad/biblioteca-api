using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BIBLIOTECA.Domain.Entities;
using BIBLIOTECA.Application.Interfaces;

namespace BIBLIOTECA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService service)
        {
            _bookService = service;
        }

        [HttpGet]
        public IEnumerable<Book> GetAll()
        {
            return _bookService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(Guid id)
        {
            return _bookService.GetById(id);
        }

        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            _bookService.Create(book);
            return book;
        }

        [HttpPut("{id}")]
        public ActionResult<Book> Update(Guid id, Book book)
        {
            _bookService.Update(id, book);
            return book;
        }

        [HttpDelete("{id}")]
        public ActionResult<Guid> Delete(Guid id)
        {
            _bookService.Delete(id);
            return id;
        }
    }
}
