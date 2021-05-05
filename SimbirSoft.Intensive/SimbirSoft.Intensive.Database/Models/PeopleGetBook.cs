using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.Intensive.Database.Models
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
    }
}
