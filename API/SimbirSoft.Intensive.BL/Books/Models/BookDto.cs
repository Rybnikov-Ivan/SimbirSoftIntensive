using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Автор книги
        /// </summary>
        [Required]
        public string Author { get; set; }

        /// <summary>
        /// Жанр книги
        /// </summary>
        [Required]
        public string Genre { get; set; }

        /// <summary>
        /// Статичный список книг
        /// </summary>
        public static List<BookDto> books = new List<BookDto>();
    }
}
