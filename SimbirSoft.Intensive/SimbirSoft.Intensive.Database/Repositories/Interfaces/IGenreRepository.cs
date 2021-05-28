using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        /// <summary>
        /// Получение всех жанров
        /// </summary>
        /// <param name="id"></param>
        IQueryable GetAll(); 

        /// <summary>
        /// Создание объекта
        /// </summary>
        /// <param name="genre"></param>
        void Add(Genre genre);

        /// <summary>
        /// Вывод статистики жанр - количество книг
        /// </summary>
        /// <param name="id"></param>
        IQueryable GetStatistic(string nameGenre);
    }
}
