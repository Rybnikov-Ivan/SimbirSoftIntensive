using System;
using System.Collections.Generic;

namespace SimbirSoft.Intensive.BL.Books.Models
{
    /// <summary>
    /// Модель книги
    /// </summary>
    public class BookDto
    {
        /// <summary>
        /// Наименование книги 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Автор книги
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Жанр книги
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Статичный список книг
        /// </summary>
        public static List<BookDto> books = new List<BookDto>();
    }
}
