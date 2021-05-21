using Microsoft.EntityFrameworkCore;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private DataContext _dataContext;
        public AuthorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable GetAll()
        {
            return _dataContext.Authors;
        }

        public IQueryable GetBooks(int id)
        {
            var existAuthor = _dataContext.Authors.Find(id);

            var booksQuery = from books in _dataContext.Books
                    join author in _dataContext.Authors on books.Id equals author.Id
                    select new
                    {
                        author,
                        book = books.Name,
                        genre = from genres in books.Genres
                                select genres.NameGenre
                    };

            return booksQuery;
        }

        public void AddAuthor(Author author)
        {
            _dataContext.Authors.Add(author);
            //if (author.Books != null)
            //{
            //    foreach (Book book in books)
            //    {
            //        Book existBook = new Book()
            //        {
            //            Author = author,
            //            Name = book.Name,
            //            Genres = book.Genres,
            //            Persons = book.Persons,
            //            TimeOfDelay = book.TimeOfDelay
            //        };

            //        _dataContext.Books.Add(existBook);
            //    }
            //}
        }

        public void AddBook(Book book)
        {
            _dataContext.Books.Add(book);
        }
        public void Delete(int id)
        {
            Author author = _dataContext.Authors.Find(id);
            if (author != null)
            {
                _dataContext.Authors.Remove(author);
            }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
