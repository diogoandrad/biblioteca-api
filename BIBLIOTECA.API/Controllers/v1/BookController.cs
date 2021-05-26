using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BIBLIOTECA.API.Models;
using System;
using System.Collections.Generic;
using BIBLIOTECA.API.Services;

namespace BIBLIOTECA.API.Controllers.v1
{
    /// <summary>
    /// API RestFull, CRUD of Books
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        /// <summary>
        /// Add Services
        /// </summary>
        /// <param name="service">Services</param>
        public BookController(IBookService service)
        {
            bookService = service;
        }

        /// <summary>
        /// Returns list of all books
        /// </summary>
        /// <returns>Books</returns>
        [HttpGet("/api/v1/books")]
        [Produces("application/json")]
        public IEnumerable<Book> GetBooks()
        {
            return bookService.GetBooks();
        }

        /// <summary>
        /// Returns unique books
        /// </summary>
        /// <returns>Book</returns>
        [HttpGet("/api/v1/books/{id}")]
        [Produces("application/json")]
        public ActionResult<Book> GetById(Guid id)
        {
            return bookService.GetById(id);
        }

        /// <summary>
        /// Add new book
        /// </summary>
        /// <param name="book">It's a book!</param>
        [HttpPost("/api/v1/books")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public ActionResult<Book> AddBook(Book book)
        {
            bookService.AddBook(book);
            return book;
        }

        /// <summary>
        /// Edit a book
        /// </summary>
        /// <param name="id"></param>
        /// <param name="book">It's a book!</param>
        [HttpPut("/api/v1/books/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public ActionResult<Book> UpdateBook(Guid id, Book book)
        {
            bookService.UpdateBook(id, book);
            return book;
        }

        /// <summary>
        /// Delete a book
        /// </summary>
        [HttpDelete("/api/v1/books/{id}")]
        [Produces("application/json")]
        public ActionResult<Guid> DeleteBook(Guid id)
        {
            bookService.DeleteBook(id);
            return id;
        }
    }
}
