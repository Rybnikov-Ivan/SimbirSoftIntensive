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
    /// Контроллер для жанров
    /// </summary>
    [ApiController]
    [Route("/api/[controller]")]
    public class GenreController
    {
        IGenreRepository _repository;
        DataContext _context;

        public GenreController (DataContext dataContext)
        {
            _repository = new GenreRepository(dataContext);
            _context = dataContext;
        }


        /// <summary>
        /// Просмотр всех жанров
        /// </summary>
        [HttpGet("getall")]
        public IQueryable GetAll()
        {
            var genres = _repository.GetAll();
            _context.SaveChanges();

            return genres;
        }

        /// <summary>
        /// Добавление нового жанра
        /// </summary>
        [HttpPost("add")]
        public Genre Add([FromBody] Genre genre)
        {
            _repository.Add(genre);
            _context.SaveChanges();

            return genre;
        }

        /// <summary>
        /// Вывод статистики жанр - количество книг
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("getstatistic/{name}")]
        public IQueryable GetStatistic([FromRoute] string name)
        {
            var statistic = _repository.GetStatistic(name);
            _context.SaveChanges();

            return statistic;
        }
    }
}
