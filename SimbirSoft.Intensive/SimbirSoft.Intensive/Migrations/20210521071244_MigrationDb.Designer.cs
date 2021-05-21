﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimbirSoft.Intensive.Database;

namespace SimbirSoft.Intensive.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210521071244_MigrationDb")]
    partial class MigrationDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("BookGenre");
                });

            modelBuilder.Entity("BookPerson", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("PersonsId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "PersonsId");

                    b.HasIndex("PersonsId");

                    b.ToTable("BookPerson");
                });

            modelBuilder.Entity("SimbirSoft.Intensive.Database.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Anton",
                            LastName = "Chechov",
                            MiddleName = "Pavlovich"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Lev",
                            LastName = "Tolstoy",
                            MiddleName = "Nicolaevich"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Aleksander",
                            LastName = "Pushkin",
                            MiddleName = "Sergeevich"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Nicolay",
                            LastName = "Gogol",
                            MiddleName = "Vasievlevich"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Ivan",
                            LastName = "Turgenev",
                            MiddleName = "Sergeevich"
                        });
                });

            modelBuilder.Entity("SimbirSoft.Intensive.Database.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TimeOfDelay")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cherry orchard",
                            TimeOfDelay = 3
                        },
                        new
                        {
                            Id = 2,
                            Name = "War and World",
                            TimeOfDelay = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Boris Godunov",
                            TimeOfDelay = 5
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dead souls",
                            TimeOfDelay = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Snowstorm",
                            TimeOfDelay = 5
                        });
                });

            modelBuilder.Entity("SimbirSoft.Intensive.Database.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameGenre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameGenre = "Novel"
                        },
                        new
                        {
                            Id = 2,
                            NameGenre = "Story"
                        },
                        new
                        {
                            Id = 3,
                            NameGenre = "Lyrics"
                        },
                        new
                        {
                            Id = 4,
                            NameGenre = "Drama"
                        },
                        new
                        {
                            Id = 5,
                            NameGenre = "Play"
                        },
                        new
                        {
                            Id = 6,
                            NameGenre = "Poem"
                        },
                        new
                        {
                            Id = 7,
                            NameGenre = "Tragedy"
                        });
                });

            modelBuilder.Entity("SimbirSoft.Intensive.Database.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1998),
                            FirstName = "Ivan",
                            LastName = "Ivanov",
                            MiddleName = "Ivanovich"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1953),
                            FirstName = "Petr",
                            LastName = "Petrov",
                            MiddleName = "Petrovich"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972),
                            FirstName = "Ekaterina",
                            LastName = "Kant",
                            MiddleName = "Alekseevna"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1933),
                            FirstName = "Anna",
                            LastName = "Malaya",
                            MiddleName = "Aleksandrovna"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1959),
                            FirstName = "Roman",
                            LastName = "Nikitin",
                            MiddleName = "Artemovich"
                        });
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("SimbirSoft.Intensive.Database.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimbirSoft.Intensive.Database.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.HasOne("SimbirSoft.Intensive.Database.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimbirSoft.Intensive.Database.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookPerson", b =>
                {
                    b.HasOne("SimbirSoft.Intensive.Database.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimbirSoft.Intensive.Database.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
