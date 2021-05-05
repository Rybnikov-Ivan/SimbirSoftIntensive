using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия человека
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Отчество человека
        /// </summary>
        [Required]
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [Required]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Статичный список с тремя моделями людей
        /// </summary>
        public static List<PeopleDto> peoples = new List<PeopleDto>();
    }

    /// <summary>
    /// Производный класс для сериализации
    /// </summary>
    public class PeopleWithoutDateOfBirth : PeopleDto
    {
        /// <summary>
        /// Дата рождения для игнорирования при записи в Json
        /// </summary>
        [JsonIgnore]
        public DateTime? DateOfBirthIgnore { get; set; }
    }
}
