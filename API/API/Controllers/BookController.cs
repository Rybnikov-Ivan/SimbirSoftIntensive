using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.BL.Books.Models;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    /// <summary>
    /// Контроллер для книг
    /// </summary>
    [ApiController]
    public class BookController : ControllerBase
    {
        /// <summary>
        /// Добавление тестовых сущностей
        /// </summary>
        public BookController()
        {
            BookDto.books.Add(new BookDto() { Name = "Cthulhu", Author = "Govard Lovecraft", Genre = "Horror" });
            BookDto.books.Add(new BookDto() { Name = "Harry Potter", Author = "Govard Lovecraft", Genre = "Fantastic" });
            BookDto.books.Add(new BookDto() { Name = "Cherry Orchard", Author = "Anton Pavlovich Chekhov", Genre = "Piece" });
        }

        /// <summary>
        /// Получение всех книг
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/books")]
        public List<BookDto> GetAll ()
        {
            return BookDto.books;
        }

        /// <summary>
        /// Получение книги по автору
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        [HttpGet("/api/books/{author}")]
        public BookDto GetByAuthor(string author)
        {
            var existBook = BookDto.books.FirstOrDefault(x => x.Author == author);

            return existBook;
        }

        /// <summary>
        /// Добавление новой книги
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost("/api/books/add")]
        public List<BookDto> Post(BookDto book)
        {
            BookDto.books.Add(new BookDto() { Name = book.Name, Author = book.Author, Genre = book.Genre });
            
            return BookDto.books;
        }

        /// <summary>
        /// Удаление книги
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpDelete("/api/books/delete")]
        public IActionResult Delete(string name)
        {
            var existBook = BookDto.books.FirstOrDefault(x => x.Author == name || x.Name == name);
            BookDto.books.Remove(existBook);

            return this.Ok();
        }

    }
}
