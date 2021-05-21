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

        public Object GetStatistic(string nameGenre)
        {
            var count = from genre in _dataContext.Genres
                            where genre.NameGenre == nameGenre
                            select new
                            {
                                Genre = genre.NameGenre,
                                Statistic = genre.Books.Count()
                            };

            var statistic = from genre in _dataContext.Genres
                     where genre.NameGenre == nameGenre
                     select new
                     {
                         genre = genre.NameGenre,
                         count = count.Count()
                     };

            return statistic.FirstOrDefault();
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
