using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BIBLIOTECA.Domain.Entities;
using BIBLIOTECA.Application.Services;

namespace BIBLIOTECA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService service)
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
            return _bookService.Create(book);
        }

        [HttpPut]
        public ActionResult<Book> Update(Book book)
        {
            return _bookService.Update(book);
        }

        [HttpDelete("{id}")]
        public ActionResult<Guid> Delete(Guid id)
        {
            return _bookService.Delete(id);
        }
    }
}
