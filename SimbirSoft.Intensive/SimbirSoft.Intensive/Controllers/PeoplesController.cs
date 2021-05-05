using Microsoft.AspNetCore.Mvc;
using SimbirSoft.Intensive.Database;
using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimbirSoft.Controllers
{
    /// <summary>
    /// Контроллер для людей
    /// </summary>
    [ApiController]
    [Route("/api/[controller]")]
    public class PeoplesController : ControllerBase
    {
        /// <summary>
        /// Добавление тестовых сущностей
        /// </summary>
        public PeoplesController()
        {
            Data.peoples.Add(new PeopleDto() { Name = "Ivan", Surname = "Ivanov", MiddleName = "Ivanovich", DateOfBirth = new DateTime() });
            Data.peoples.Add(new PeopleDto() { Name = "Marina", Surname = "Svetlaya", MiddleName = "Marinovna", DateOfBirth = new DateTime() });
            Data.peoples.Add(new PeopleDto() { Name = "Petr", Surname = "Petrov", MiddleName = "Petrovich", DateOfBirth = new DateTime() });
        }

        /// <summary>
        /// Получение всех людей
        /// </summary>
        [HttpGet]
        public List<PeopleDto> GetAll()
        {
            return Data.peoples;
        }

        /// <summary>
        /// Получение человека по имени
        /// </summary>
        /// <param name="name"></param>
        [HttpGet("{name}")]
        public PeopleDto GetByAuthor([FromRoute] string name)
        {
            var existPeople = Data.peoples.FirstOrDefault(x => x.Name == name);

            return existPeople;
        }

        /// <summary>
        /// Добавление нового человека
        /// </summary>
        /// <param name="people"></param>
        [HttpPost("add")]
        public List<PeopleDto> Add([FromBody] PeopleDto people)
        {
            var peopleSerialize =
                new PeopleWithoutDateOfBirth
                {
                    Name = people.Name,
                    Surname = people.Surname,
                    MiddleName = people.MiddleName,
                    DateOfBirthIgnore = people.DateOfBirth,
                    DateOfBirth = null
                };

            Data.peoples.Add(new PeopleWithoutDateOfBirth() 
            {   Name = peopleSerialize.Name, 
                Surname = peopleSerialize.Surname, 
                MiddleName = peopleSerialize.MiddleName, 
                DateOfBirthIgnore = peopleSerialize.DateOfBirthIgnore 
            });

            return Data.peoples;
        }

        /// <summary>
        /// Удаление человека по ФИО
        /// </summary>
        /// <param name="name"></param>
        [HttpDelete("delete")]
        public IActionResult Delete([FromBody] PeopleDto people)
        {
            var existPeople = Data.peoples.FirstOrDefault(x => x.Name == people.Name && x.Surname == people.Surname && x.MiddleName == people.MiddleName);
            Data.peoples.Remove(existPeople);

            return Ok();
        }
    }
}
