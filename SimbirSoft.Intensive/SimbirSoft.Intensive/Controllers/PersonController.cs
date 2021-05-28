using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.Database;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimbirSoft.Controllers
{
    /// <summary>
    /// Контроллер для людей
    /// </summary>
    [ApiController]
    [Route("/api/[controller]")]
    public class PersonController : ControllerBase
    {
        IPersonRepository _repository;
        DataContext _context;

        public PersonController(DataContext dataContext)
        {
            _repository = new PersonRepository(dataContext);
            _context = dataContext;
        }

        /// <summary>
        /// Получение книг пользователем (Книги - автор- жанр)
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("getbook/{id}")]
        public IQueryable GetBook([FromRoute] int id)
        {
            return _repository.GetBook(id);
        }

        /// <summary>
        /// Добавление нового человека
        /// </summary>
        /// <param name="person"></param>
        [HttpPost("add")]
        public Person Add([FromBody] Person person)
        {
            _repository.Add(person);
            _context.SaveChanges();

            return person;
        }

        /// <summary>
        /// Обновление модели человека
        /// </summary>
        /// <param name="person"></param>
        [HttpPut("update/{id}")]
        public Person Update([FromRoute] int id, [FromBody] Person person)
        {
            _repository.Update(id, person);
            _context.SaveChanges();

            return person;
        }

        /// <summary>
        /// Удаление человека по ФИО
        /// </summary>
        /// <param name="person"></param>
        [HttpDelete("delete")]
        public IActionResult DeleteByFio([FromBody] Person person)
        {
            _repository.DeleteByFIO(person);
            _context.SaveChanges();

            return Ok();
        }

        /// <summary>
        /// Удаление человека по id
        /// </summary>
        /// <param name="name"></param>
        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _repository.Delete(id);
            _context.SaveChanges();

            return Ok();
        }

        /// <summary>
        /// Добавление в список книг пользователя новой книги
        /// </summary>
        /// <param name="id"></param>
        /// <param name="book"></param>
        [HttpPost("addbook/{id}")]
        public IActionResult AddBook([FromRoute] int id,[FromBody] Book book)
        {
            _repository.AddBook(id, book);
            _context.SaveChanges();

            return Ok();
        }

        /// <summary>
        /// Удалине из списка книг пользователя книги
        /// </summary>
        /// <param name="id"></param>
        /// <param name="book"></param>
        [HttpDelete("deletebook/{id}")]
        public IActionResult DeleteBook([FromRoute] int id,[FromBody] Book book)
        {
            _repository.DeleteBook(id, book);
            _context.SaveChanges();

            return Ok();
        }
    }
}
