using Microsoft.EntityFrameworkCore;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Author> GetAuthorList()
        {
            return _dataContext.Authors;
        }

        public Author GetAuthor(int id)
        {
            return _dataContext.Authors.Find(id);
        }

        public void Add(Author author)
        {
            _dataContext.Authors.Add(author);
        }

        public void Update(Author author)
        {
            _dataContext.Entry(author).State = EntityState.Modified;
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
