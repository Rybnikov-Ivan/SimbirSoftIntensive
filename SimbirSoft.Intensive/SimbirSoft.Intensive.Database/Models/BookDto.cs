﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SimbirSoft.Intensive.Database.Models
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

    /// <summary>
    /// Производный класс для сериализации
    /// </summary>
    public class BookWithoutGenre : BookDto
    {
        /// <summary>
        /// Жанр для игнорирования записи в JSON
        /// </summary>
        [JsonIgnore]
        public string GenreIgnore { get; set; }
    }
}
