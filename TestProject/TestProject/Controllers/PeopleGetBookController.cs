using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.BL.PeopleGetBook.Models;
using System.Collections.Generic;

namespace TestProject.Controllers
{
    /// <summary>
    /// Контроллер, отвечающий за получение книги человеком
    /// </summary>
    [ApiController]
    public class PeopleGetBookController : ControllerBase
    {
        /// <summary>
        /// Контроллер для сущности-агрегатора
        /// </summary>
        /// <returns></returns>
        [HttpPost("/api/peoplegetbook/add")]
        public List<PeopleGetBook> Post(PeopleGetBook peopleGetBook)
        {
            PeopleGetBook.peopleGetBooks.Add(new PeopleGetBook { People = peopleGetBook.People, Book = peopleGetBook.Book, DateAndTime = peopleGetBook.DateAndTime });

            return PeopleGetBook.peopleGetBooks;
        }
    }
}
