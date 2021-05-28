using Microsoft.EntityFrameworkCore;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SimbirSoft.Intensive.Database.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private DataContext _dataContext;
        ICollection<Book> bookCollection = new List<Book>();

        public PersonRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Person GetPerson(int id)
        {
            return _dataContext.Persons.Find(id);
        }

        public void Add(Person person)
        {
            _dataContext.Persons.Add(person);
        }

        public IQueryable GetBook(int id)
        {
            var booksQuery = from persons in _dataContext.Persons
                              where persons.Id == id
                              select new
                              {
                                  Books = from books in persons.Books
                                          select new
                                          {
                                              books.Name,
                                              books.Genres,
                                          }                                         
                              };
            return booksQuery;            
        }

        public void Update(int id, Person person)
        {
            var existPerson = _dataContext.Persons.Find(id);
            _dataContext.Persons.Remove(existPerson);

            var updatedPerson = new Person
            {
                Id = id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                MiddleName = person.MiddleName,
                DateOfBirth = person.DateOfBirth,
                Books = person.Books
            };
            _dataContext.Persons.Add(updatedPerson);
        }

        public void Delete(int id)
        {
            Person person = _dataContext.Persons.Find(id);
            if (person != null)
            {
                _dataContext.Persons.Remove(person);
            } 
            else
            {
                throw new ArgumentException(nameof(person));
            }
        }

        public void DeleteByFIO(Person person)
        {
            Person existPerson = _dataContext.Persons.FirstOrDefault(x => x.FirstName == person.FirstName && x.LastName == person.LastName && x.MiddleName == person.MiddleName);
            if (existPerson != null)
            {
                _dataContext.Persons.Remove(existPerson);
            }
            else
            {
                throw new ArgumentException(nameof(existPerson));
            }
        }

        public void AddBook(int id, Book book)
        {
            Person person = _dataContext.Persons.Find(id);

            person.Books = bookCollection;
            person.Books.Add(book);

        }

        public void DeleteBook(int id, Book book)
        {
            Person person = _dataContext.Persons.Find(id);

            person.Books = bookCollection;
            person.Books.Remove(book);

        }
    }
}
