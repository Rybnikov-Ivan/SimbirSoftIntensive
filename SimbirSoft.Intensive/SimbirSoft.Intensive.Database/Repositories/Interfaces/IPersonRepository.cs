using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        /// <summary>
        /// Получение всех объектов - людей
        /// </summary>
        IEnumerable<Person> GetPersonList(); 

        /// <summary>
        /// Получение человека по id
        /// </summary>
        /// <param name="id"></param>
        Person GetPerson(int id);

        /// <summary>
        /// Добавление человека
        /// </summary>
        /// <param name="person"></param>
        void Add(Person person); 

        /// <summary>
        /// Обновление объекта
        /// </summary>
        /// <param name="person"></param>
        void Update(Person person); 

        /// <summary>
        /// Удаление объекта по id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        void Save();
    }
}
