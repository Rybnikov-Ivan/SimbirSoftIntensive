using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.BL.Peoples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    /// <summary>
    /// Контроллер для людей
    /// </summary>
    [ApiController]
    public class PeopleController : ControllerBase
    {
        /// <summary>
        /// Добавление тестовых сущностей
        /// </summary>
        public PeopleController()
        {
            PeopleDto.peoples.Add(new PeopleDto() { Name = "Ivan", Surname = "Ivanov", MiddleName = "Ivanovich", DateOfBirth = new DateTime() });
            PeopleDto.peoples.Add(new PeopleDto() { Name = "Marina", Surname = "Svetlaya", MiddleName = "Marinovna", DateOfBirth = new DateTime() });
            PeopleDto.peoples.Add(new PeopleDto() { Name = "Petr", Surname = "Petrov", MiddleName = "Petrovich", DateOfBirth = new DateTime() });
        }

        /// <summary>
        /// Получение всех людей
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/peoples")]
        public List<PeopleDto> GetAll()
        {
            return PeopleDto.peoples;
        }

        /// <summary>
        /// Получение человека по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("/api/peoples/{name}")]
        public PeopleDto GetByAuthor(string name)
        {
            var existPeople = PeopleDto.peoples.FirstOrDefault(x => x.Name == name);

            return existPeople;
        }

        /// <summary>
        /// Добавление нового человека
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        [HttpPost("/api/peoples/add")]
        public List<PeopleDto> Post(PeopleDto people)
        {
            PeopleDto.peoples.Add(new PeopleDto() { Name = people.Name, Surname = people.Surname, MiddleName = people.MiddleName, DateOfBirth = people.DateOfBirth });

            return PeopleDto.peoples;
        }

        /// <summary>
        /// Удаление человека
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpDelete("/api/peoples/delete")]
        public IActionResult Delete(string name)
        {
            var existPeople = PeopleDto.peoples.FirstOrDefault(x => x.Name == name || x.Surname == name || x.MiddleName == name);
            PeopleDto.peoples.Remove(existPeople);

            return this.Ok();
        }
    }
}
