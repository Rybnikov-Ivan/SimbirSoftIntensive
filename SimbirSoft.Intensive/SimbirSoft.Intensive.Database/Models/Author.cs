using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimbirSoft.Intensive.Database.Models
{
    [Table("Author")]
    public class Author
    {
        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя автора
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия автора
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество автора
        /// </summary>
        public string MiddleName { get; set; }
    }
}
