using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.Database;
using SimbirSoft.Intensive.Database.Models;
using System.Collections.Generic;

namespace SimbirSoft.Controllers
{
    /// <summary>
    /// Контроллер, отвечающий за получение книги человеком
    /// </summary>
    [ApiController]
    [Route("/api/[controller]")]
    public class PeopleGetBookController : ControllerBase
    {
        /// <summary>
        /// Контроллер для сущности-агрегатора
        /// </summary>
        [HttpPost("add")]
        public List<PeopleGetBook> Add([FromBody] PeopleGetBook peopleGetBook)
        {
            Data.peopleGetBooks.Add(new PeopleGetBook { People = peopleGetBook.People, Book = peopleGetBook.Book, DateAndTime = peopleGetBook.DateAndTime });

            return Data.peopleGetBooks;
        }
    }
}
