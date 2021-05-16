using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories.Interfaces
{
    public interface IBookRepository
    {
        /// <summary>
        /// Получение всех объектов - книг
        /// </summary>
        IEnumerable<Book> GetBookList(); 

        /// <summary>
        /// Получение книги по id
        /// </summary>
        /// <param name="id"></param>
        Book GetBook(int id); // получение одного объекта по id

        /// <summary>
        /// Создание объекта
        /// </summary>
        /// <param name="book"></param>
        void Add(Book book); 

        /// <summary>
        /// Обновление объекта
        /// </summary>
        /// <param name="book"></param>
        void Update(Book book); 

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
