using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.Database;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
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
    public class BookController : ControllerBase
    {
        IBookRepository _dataContext;
        public BookController(DataContext dataContext)
        {
            _dataContext = new BookRepository(dataContext);
        }

        /// <summary>
        /// Добавление новой книги
        /// </summary>
        /// <param name="book"></param>
        [HttpPost("add")]
        public Book Add([FromBody] Book book)
        {
            _dataContext.Add(book);
            _dataContext.Save();

            return book;
        }

        /// <summary>
        /// Добавление жанра к книге
        /// </summary>
        /// <param name="book"></param>
        [HttpPut("addgenre")]
        public Book AddGenre([FromBody] Book book)
        {
            _dataContext.AddGenre(book);
            _dataContext.Save();

            return book;
        }

        /// <summary>
        /// Удаление у книги жанра
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        //[HttpPut("deletegenre")]
        //public Book DeleteGenre([FromBody] Book book)
        //{
        //    _dataContext.DeleteGenre(book);
        //    _dataContext.Save();

        //    return book;
        //}

        /// <summary>
        /// Удаление книги по id (если она не у пользователя)
        /// </summary>
        /// <param name="name"></param>
        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _dataContext.Delete(id);
            _dataContext.Save();

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
