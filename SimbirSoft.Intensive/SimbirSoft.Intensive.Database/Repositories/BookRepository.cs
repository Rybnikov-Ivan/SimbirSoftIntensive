using Microsoft.EntityFrameworkCore;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Book> GetBookList()
        {
            return _dataContext.Books;
        }

        public Book GetBook(int id)
        {
            return _dataContext.Books.Find(id);
        }

        public void Add(Book book)
        {
            _dataContext.Books.Add(book);
        }

        public void Update(Book book)
        {
            _dataContext.Entry(book).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Book book = _dataContext.Books.Find(id);
            if (book != null)
            {
                _dataContext.Books.Remove(book);
            }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
