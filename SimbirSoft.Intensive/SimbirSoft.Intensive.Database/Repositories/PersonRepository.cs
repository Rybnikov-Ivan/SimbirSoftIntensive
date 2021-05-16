using Microsoft.EntityFrameworkCore;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private DataContext _dataContext;
        public PersonRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Person> GetPersonList()
        {
            return _dataContext.Persons;
        }

        public Person GetPerson(int id)
        {
            return _dataContext.Persons.Find(id);
        }

        public void Add(Person person)
        {
            _dataContext.Persons.Add(person);
        }

        public void Update(Person person)
        {
            _dataContext.Entry(person).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Person person = _dataContext.Persons.Find(id);
            if (person != null)
            {
                _dataContext.Persons.Remove(person);
            }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
