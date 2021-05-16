using Microsoft.EntityFrameworkCore;
using SimbirSoft.Intensive.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.Intensive.Database
{
    /// <summary>
    /// Контекст данных
    /// </summary>
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Конфигурация моделей с помощью FluentApi
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Создание первичный ключей
            modelBuilder.Entity<Person>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Book>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Author>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Genre>()
                .HasKey(p => p.Id);

            // Добавление связей между таблицами
            modelBuilder.Entity<Person>()
                .HasMany(p => p.Books)
                .WithMany(p => p.Persons);
            modelBuilder.Entity<Book>()
                .HasOne(p => p.Author).WithOne();
            modelBuilder.Entity<Book>()
                .HasMany(p => p.Genres)
                .WithMany(p => p.Books);

            // Добавление свойств сущности человек
            modelBuilder.Entity<Person>()
                .Property(p => p.FirstName)
                .IsRequired();
            modelBuilder.Entity<Person>()
                .Property(p => p.LastName)
                .IsRequired();

            // Добавление свойств полей сущности книга
            modelBuilder.Entity<Book>()
                .Property(p => p.Name)
                .IsRequired();
            modelBuilder.Entity<Book>()
                .Property(p => p.AuthorId)
                .IsRequired();

            // Добавление свойств полей сущности автор
            modelBuilder.Entity<Author>()
                .Property(p => p.FirstName)
                .IsRequired();
            modelBuilder.Entity<Author>()
                .Property(p => p.LastName)
                .IsRequired();

            // Добавление свойств полей сущности жанр
            modelBuilder.Entity<Genre>()
                .Property(p => p.NameGenre)
                .IsRequired();
        }
    }
}
