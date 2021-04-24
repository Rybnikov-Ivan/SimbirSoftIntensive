using System;
using System.Collections.Generic;

namespace SimbirSoft.Intensive.BL.Peoples.Models
{
    /// <summary>
    /// Модель человека
    /// </summary>
    public class PeopleDto
    {
        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия человека
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество человека
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Статичный список с тремя моделями людей
        /// </summary>
        public static List<PeopleDto> peoples = new List<PeopleDto>();
    }
}
