using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimbirSoft.Intensive.Database.Models
{
    [Table("Genre")]
    public class Genre
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование жанра
        /// </summary>
        public string NameGenre { get; set; }

        /// <summary>
        /// Книги жанра
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}
