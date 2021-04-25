using SimbirSoft.Intensive.BL.Books.Models;
using SimbirSoft.Intensive.BL.Peoples.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.Intensive.BL.PeopleGetBook.Models
{
    /// <summary>
    /// Класс, отвечающий за получение человеком книги
    /// </summary>
    public class PeopleGetBook
    {
        /// <summary>
        /// Человек
        /// </summary>
        [Required]
        public PeopleDto People { get; set; }

        /// <summary>
        /// Книга
        /// </summary>
        [Required]
        public BookDto Book { get; set; }

        /// <summary>
        /// Дата и время получения книги
        /// </summary>
        [Required]
        public DateTimeOffset DateAndTime { get; set; }

        /// <summary>
        /// Список, отвечающий за хранение сущностей
        /// </summary>
        public static List<PeopleGetBook> peopleGetBooks = new List<PeopleGetBook>();
    }
}
