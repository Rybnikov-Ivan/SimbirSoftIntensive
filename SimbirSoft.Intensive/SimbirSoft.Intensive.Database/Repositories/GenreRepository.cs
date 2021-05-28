using Microsoft.EntityFrameworkCore;
using SimbirSoft.Intensive.Database.Models;
using SimbirSoft.Intensive.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IQueryable GetAll()
        {
            return _dataContext.Genres;
        }

        public void Add(Genre genre)
        {
            _dataContext.Genres.Add(genre);
        }

        public IQueryable GetStatistic(string nameGenre)
        {
            var result = _dataContext.Genres.Where(x => x.NameGenre == nameGenre)
                .Select(g => new { NameGenre = g.NameGenre, Count = g.Books.Count() });

            return result;
        }
    }
}
