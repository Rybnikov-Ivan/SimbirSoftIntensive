using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories.Interfaces
{
    public interface IBookRepository
    {
        /// <summary>
        /// Получение книги по id
        /// </summary>
        /// <param name="id"></param>
        Book GetBook(int id); // получение одного объекта по id

        /// <summary>
        /// Добавление книги
        /// </summary>
        /// <param name="book"></param>
        void Add(Book book); 

        /// <summary>
        /// Добавление жанра
        /// </summary>
        /// <param name="book"></param>
        void AddGenre(Book book);

        /// <summary>
        /// Удаление жанра у книги
        /// </summary>
        /// <param name="book"></param>
        //void DeleteGenre(Book book);

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
