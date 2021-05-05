using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.Database;
using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimbirSoft.Intensive.Controllers
{
    /// <summary>
    /// Контроллер для книг
    /// </summary>
    [ApiController]
    [Route("/api/[controller]")]
    public class BooksController : ControllerBase
    {
        /// <summary>
        /// Добавление тестовых сущностей
        /// </summary>
        public BooksController()
        {
            Data.books.Add(new BookDto() { Name = "Cthulhu", Author = "Govard Lovecraft", Genre = "Horror" });
            Data.books.Add(new BookDto() { Name = "Harry Potter", Author = "Govard Lovecraft", Genre = "Fantastic" });
            Data.books.Add(new BookDto() { Name = "Cherry Orchard", Author = "Anton Pavlovich Chekhov", Genre = "Piece" });
        }

        /// <summary>
        /// Получение всех книг
        /// </summary>
        [HttpGet]
        public List<BookDto> GetAll ()
        {
            return Data.books;
        }

        /// <summary>
        /// Получение книги по автору
        /// </summary>
        /// <param name="author"></param>
        [HttpGet("{author}")]
        public BookDto GetByAuthor([FromRoute] string author)
        {
            var existBook = Data.books.FirstOrDefault(x => x.Author == author);

            return existBook;
        }

        /// <summary>
        /// Добавление новой книги
        /// </summary>
        /// <param name="book"></param>
        [HttpPost("add")]
        public List<BookDto> Add([FromBody] BookDto book)
        {
            var bookSerialize =
                new BookWithoutGenre
                {
                    Name = book.Name,
                    Author = book.Author,
                    GenreIgnore = book.Genre
                };

            Data.books.Add(new BookWithoutGenre() { Name = bookSerialize.Name, Author = bookSerialize.Author, GenreIgnore = bookSerialize.GenreIgnore});

            return Data.books;
        }

        /// <summary>
        /// Удаление книги по автору
        /// </summary>
        /// <param name="name"></param>
        [HttpDelete("deletebyauthor/{author}")]
        public IActionResult DeleteByAuthor([FromRoute] string author)
        {
            var existBook = Data.books.FirstOrDefault(x => x.Author == author);
            Data.books.Remove(existBook);

            return Ok();
        }

        /// <summary>
        /// Удаление книги по названию
        /// </summary>
        /// <param name="name"></param>
        [HttpDelete("deletebyname/{name}")]
        public IActionResult DeleteByName([FromRoute] string name)
        {
            var existBook = Data.books.FirstOrDefault(x => x.Name == name);
            Data.books.Remove(existBook);

            return Ok();
        }
    }
}
