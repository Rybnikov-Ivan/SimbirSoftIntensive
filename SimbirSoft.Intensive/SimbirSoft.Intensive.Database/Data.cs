using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database
{
    public static class Data
    {
        /// <summary>
        /// Статичный список книг
        /// </summary>
        public static List<BookDto> books = new List<BookDto>();

        /// <summary>
        /// Статичный список с тремя моделями людей
        /// </summary>
        public static List<PeopleDto> peoples = new List<PeopleDto>();

        /// <summary>
        /// Список, отвечающий за хранение сущностей
        /// </summary>
        public static List<PeopleGetBook> peopleGetBooks = new List<PeopleGetBook>();
    }
}
