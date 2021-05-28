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
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
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

            //Добавление связей между таблицами
            modelBuilder.Entity<Person>()
                .HasMany(p => p.Books)
                .WithMany(p => p.Persons)
                .UsingEntity(j => j.ToTable("BookPerson"));

            modelBuilder.Entity<Book>()
                .HasMany(p => p.Authors)
                .WithMany(p => p.Books)
                .UsingEntity(j => j.ToTable("BookAuthor"));

            modelBuilder.Entity<Book>()
                .HasMany(p => p.Genres)
                .WithMany(p => p.Books)
                .UsingEntity(j => j.ToTable("BookGenre"));


            // Добавление свойств сущности человек
            modelBuilder.Entity<Person>()
                .Property(p => p.FirstName)
                .IsRequired();
            modelBuilder.Entity<Person>()
                .Property(p => p.LastName)
                .IsRequired();

            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, FirstName = "Ivan", LastName = "Ivanov", MiddleName = "Ivanovich", DateOfBirth = new DateTime(2000 - 01 - 01)},
                new Person { Id = 2, FirstName = "Petr", LastName = "Petrov", MiddleName = "Petrovich", DateOfBirth = new DateTime(1977 - 04 - 20) },
                new Person { Id = 3, FirstName = "Ekaterina", LastName = "Kant", MiddleName = "Alekseevna", DateOfBirth = new DateTime(1999 - 12 - 15) },
                new Person { Id = 4, FirstName = "Anna", LastName = "Malaya", MiddleName = "Aleksandrovna", DateOfBirth = new DateTime(2004 - 01 - 070) },
                new Person { Id = 5, FirstName = "Roman", LastName = "Nikitin", MiddleName = "Artemovich", DateOfBirth = new DateTime(1980 - 10 - 11) });
            
            // Добавление свойств полей сущности книга
            modelBuilder.Entity<Book>()
                .Property(p => p.Name)
                .IsRequired();

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Cherry orchard", TimeOfDelay = 3 },
                new Book { Id = 2, Name = "War and World", TimeOfDelay = 2 },
                new Book { Id = 3, Name = "Boris Godunov", TimeOfDelay = 5 },
                new Book { Id = 4, Name = "Dead souls", TimeOfDelay = 0 },
                new Book { Id = 5, Name = "Snowstorm", TimeOfDelay = 5 });

            // Добавление свойств полей сущности автор
            modelBuilder.Entity<Author>()
                .Property(p => p.FirstName)
                .IsRequired();
            modelBuilder.Entity<Author>()
                .Property(p => p.LastName)
                .IsRequired();

            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, FirstName = "Anton", LastName = "Chechov", MiddleName = "Pavlovich" },
                new Author { Id = 2, FirstName = "Lev", LastName = "Tolstoy", MiddleName = "Nicolaevich" },
                new Author { Id = 3, FirstName = "Aleksander", LastName = "Pushkin", MiddleName = "Sergeevich" },
                new Author { Id = 4, FirstName = "Nicolay", LastName = "Gogol", MiddleName = "Vasievlevich" },
                new Author { Id = 5, FirstName = "Ivan", LastName = "Turgenev", MiddleName = "Sergeevich" });

            // Добавление свойств полей сущности жанр
            modelBuilder.Entity<Genre>()
                .Property(p => p.NameGenre)
                .IsRequired();

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, NameGenre = "Novel" },
                new Genre { Id = 2, NameGenre = "Story" },
                new Genre { Id = 3, NameGenre = "Lyrics" },
                new Genre { Id = 4, NameGenre = "Drama" },
                new Genre { Id = 5, NameGenre = "Play" },
                new Genre { Id = 6, NameGenre = "Poem" },
                new Genre { Id = 7, NameGenre = "Tragedy" });
        }
    }
}
