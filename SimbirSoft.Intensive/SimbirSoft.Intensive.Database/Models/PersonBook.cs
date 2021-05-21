using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database.Models
{
    /// <summary>
    /// Связь между пользователем и книгой 
    /// </summary>
    public class PersonBook
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Id книги
        /// </summary>
        public int BookId { get; set; }
    }
}
