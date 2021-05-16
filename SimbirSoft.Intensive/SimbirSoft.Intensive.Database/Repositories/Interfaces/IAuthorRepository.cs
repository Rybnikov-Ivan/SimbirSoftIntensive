using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        /// <summary>
        /// Получение всех объектов - авторов
        /// </summary>
        IEnumerable<Author> GetAuthorList();

        /// <summary>
        /// Получение одного автора по id
        /// </summary>
        /// <param name="id"></param>
        Author GetAuthor(int id);
        
        /// <summary>
        /// Создание объекта
        /// </summary>
        /// <param name="author"></param>
        void Add(Author author);

        /// <summary>
        /// Обновление объекта
        /// </summary>
        /// <param name="author"></param>
        void Update(Author author);

        /// <summary>
        /// Удаление объекта
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id); 

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        void Save();
    }
}
