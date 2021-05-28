using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        /// <summary>
        /// Получение всех авторов
        /// </summary>
        IQueryable GetAll();

        /// <summary>
        /// Получение одного автора по id
        /// </summary>
        /// <param name="id"></param>
        IQueryable GetBooks(int id);
        
        /// <summary>
        /// Добавление автора
        /// </summary>
        /// <param name="author"></param>
        void AddAuthor(Author author);

        /// <summary>
        /// Удаление автора (если у него нет книг)
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id); 
    }
}
