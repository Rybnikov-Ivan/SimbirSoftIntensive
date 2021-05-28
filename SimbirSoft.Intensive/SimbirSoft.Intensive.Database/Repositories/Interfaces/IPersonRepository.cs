using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SimbirSoft.Intensive.Database.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        /// <summary>
        /// Добавление человека
        /// </summary>
        /// <param name="person"></param>
        void Add(Person person);

        /// <summary>
        /// Cписок всех взятых пользователем книг
        /// </summary>
        /// <param name="id"></param>
        IQueryable GetBook(int id);

        /// <summary>
        /// Обновление объекта
        /// </summary>
        /// <param name="person"></param>
        void Update(int id, Person person); 

        /// <summary>
        /// Удаление объекта по id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Удаление объекта по ФИО
        /// </summary>
        /// <param name="person"></param>
        void DeleteByFIO(Person person);

        /// <summary>
        /// Добавление в список книг пользователя новой книги
        /// </summary>
        /// <param name="id"></param>
        /// <param name="book"></param>
        void AddBook(int id, Book book);

        /// <summary>
        /// Удаление из списка книг пользователя книги
        /// </summary>
        /// <param name="id"></param>
        /// <param name="book"></param>
        void DeleteBook(int id, Book book);
    }
}
