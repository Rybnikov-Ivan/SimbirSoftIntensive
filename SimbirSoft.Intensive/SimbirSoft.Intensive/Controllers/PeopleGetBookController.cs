using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.BL.PeopleGetBook.Models;
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
            PeopleGetBook.peopleGetBooks.Add(new PeopleGetBook { People = peopleGetBook.People, Book = peopleGetBook.Book, DateAndTime = peopleGetBook.DateAndTime });

            return PeopleGetBook.peopleGetBooks;
        }
    }
}
