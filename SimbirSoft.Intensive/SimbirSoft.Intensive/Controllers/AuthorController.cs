using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.Database;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbirSoft.Intensive.Controllers
{
    /// <summary>
    /// Контроллер для авторов
    /// </summary>
    [ApiController]
    [Route("/api/[controller]")]
    public class AuthorController
    {
        IAuthorRepository _dataContext;
        public AuthorController(DataContext dataContext)
        {
            _dataContext = new AuthorRepository(dataContext);
        }

        /// <summary>
        /// Получение всех авторов
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IQueryable GetAll()
        {
            return _dataContext.GetAll();
        }

        /// <summary>
        /// Получить список книг автора (автор - книги- жанры)
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("getbooks/{id}")]
        public IQueryable GetBooks([FromRoute]int id)
        {
            return _dataContext.GetBooks(id);
        }
        
        /// <summary>
        /// Добавить автора
        /// </summary>
        /// <param name="author"></param>
        /// <param name="book"></param>
        [HttpPost("add")]
        public Author Add([FromBody] Author author)
        {
            _dataContext.AddAuthor(author);

            _dataContext.Save();

            return author;
        }
    }
}
