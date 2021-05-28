using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimbirSoft.Intensive.Database.Models
{
    [Table("Book")]
    public class Book
    {
        /// <summary>
        /// Идентификатор книги
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование книги
        /// </summary>
        public string Name { get; set; }
            
        /// <summary>
        /// Время просрочки сдачи книги
        /// </summary>
        public int TimeOfDelay { get; set; }
        
        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public ICollection<Author> Authors { get; set; }

        /// <summary>
        /// Книги, которые взяли пользователи
        /// </summary>
        public ICollection<Person> Persons { get; set; }

        /// <summary>
        /// Жанры книги
        /// </summary>
        public ICollection<Genre> Genres { get; set; }
    }
}
