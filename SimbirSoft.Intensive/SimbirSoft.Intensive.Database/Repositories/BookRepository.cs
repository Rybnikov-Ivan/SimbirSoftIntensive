using Microsoft.EntityFrameworkCore;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories
{
    public class BookRepository : IBookRepository
    {
        private DataContext _dataContext;
        public BookRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Book GetBook(int id)
        {
            return _dataContext.Books.Find(id);
        }

        public void Add(Book book)
        {
            _dataContext.Books.Add(book);
        }

        public void AddGenre(Book book)
        {
            var existBook = _dataContext.Books.FirstOrDefault(x => x.Name == book.Name);

            existBook.Genres = book.Genres;
        }

        //public void DeleteGenre(Book book)
        //{
        //    Book existBook = _dataContext.Books.FirstOrDefault(x => x.Name == book.Name);
        //    var ex = _dataContext.Books.Include(x => x.Genres).Where(x => x.Name == book.Name).Select(x => x.Genres).ToList();
            
        //    existBook.Genres.Remove(ex);
        //}

        public void Delete(int id)
        {
            var existBook = _dataContext.Books.FirstOrDefault(x => x.Id == id && !x.Persons.Any());

            if (existBook != null)
            {
                _dataContext.Books.Remove(existBook);
            }
            else
            {
                throw new ArgumentException("Книга находится у пользователя");
            }
        }

        public IQueryable GetBookByGenre (string genreName)
        {
            var query = from genre in _dataContext.Genres
                        where genre.NameGenre == genreName
                        select new
                        {
                            Genre = genre.NameGenre,
                            Books = from books in genre.Books
                                    select new
                                    {
                                        books,
                                        author = from auth in books.Authors
                                                 select auth
                                    }
                        };
            return query;
        }
    }
}
