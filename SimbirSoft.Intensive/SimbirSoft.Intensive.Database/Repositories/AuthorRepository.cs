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

            var booksQuery = from author in _dataContext.Authors
                             where existAuthor.LastName == author.LastName
                             select new
                             {
                                 author,
                                 book = from books in author.Books
                                        select new
                                        {
                                            books = books,
                                            genres = from genre in books.Genres
                                                     select genre
                                        }
                    };

            return booksQuery;
        }

        public void AddAuthor(Author author)
        {
            _dataContext.Authors.Add(author);
        }

        public void Delete(int id)
        {
            var existAuthor = _dataContext.Authors.Find(id);
            var check = _dataContext.Authors.FirstOrDefault(x => x.Id == id && x.Books.Any());
            if (check == null)
            {
                _dataContext.Authors.Remove(existAuthor);
            }
            else
            {
                throw new ArgumentException("У автора есть книги, удалить нельзя");
            }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
