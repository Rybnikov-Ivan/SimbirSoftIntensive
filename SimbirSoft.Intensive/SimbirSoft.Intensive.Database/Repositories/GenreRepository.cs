using Microsoft.EntityFrameworkCore;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private DataContext _dataContext;
        public GenreRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Genre> GetGenreList()
        {
            return _dataContext.Genres;
        }

        public Genre GetAuthor(int id)
        {
            return _dataContext.Genres.Find(id);
        }

        public void Add(Genre genre)
        {
            _dataContext.Genres.Add(genre);
        }

        public void Update(Genre genre)
        {
            _dataContext.Entry(genre).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Genre genre = _dataContext.Genres.Find(id);
            if (genre != null)
            {
                _dataContext.Genres.Remove(genre);
            }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
