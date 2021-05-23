using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimbirSoft.Intensive.Database.Models
{
    [Table("Person")]
    public class Person
    {
        /// <summary>
        /// Идентификатор человека
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя человека
        /// </summary
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия человека
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество человека
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Книги, которые находятся у человека
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}
