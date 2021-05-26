using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BIBLIOTECA.Domain.Entities;
using BIBLIOTECA.Application.Interfaces;

namespace BIBLIOTECA.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController(IBookService service)
        {
            bookService = service;
        }

        [HttpGet("/api/v1/books")]
        [Produces("application/json")]
        public IEnumerable<Book> GetBooks()
        {
            return bookService.GetBooks();
        }

        [HttpGet("/api/v1/books/{id}")]
        [Produces("application/json")]
        public ActionResult<Book> GetById(Guid id)
        {
            return bookService.GetById(id);
        }

        [HttpPost("/api/v1/books")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public ActionResult<Book> AddBook(Book book)
        {
            bookService.AddBook(book);
            return book;
        }

        [HttpPut("/api/v1/books/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public ActionResult<Book> UpdateBook(Guid id, Book book)
        {
            bookService.UpdateBook(id, book);
            return book;
        }

        [HttpDelete("/api/v1/books/{id}")]
        [Produces("application/json")]
        public ActionResult<Guid> DeleteBook(Guid id)
        {
            bookService.DeleteBook(id);
            return id;
        }
    }
}
