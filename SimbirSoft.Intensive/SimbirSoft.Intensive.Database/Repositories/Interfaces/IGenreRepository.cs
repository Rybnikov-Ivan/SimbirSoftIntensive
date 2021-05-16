using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        /// <summary>
        /// Получение всех объектов - жанров
        /// </summary>
        IEnumerable<Genre> GetGenreList();

        /// <summary>
        /// Gолучение автора по id
        /// </summary>
        /// <param name="id"></param>
        Genre GetAuthor(int id); 

        /// <summary>
        /// Создание объекта
        /// </summary>
        /// <param name="genre"></param>
        void Add(Genre genre);

        /// <summary>
        /// Обновление объекта
        /// </summary>
        /// <param name="genre"></param>
        void Update(Genre genre);

        /// <summary>
        /// Удаление объекта по id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        void Save();
    }
}
