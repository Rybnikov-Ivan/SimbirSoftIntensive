USE [SimbirSoft.Intensive]
GO


/*Заполнение таблицы person*/
INSERT INTO [person]
([birth_date],[first_name],[last_name],[middle_name])
VALUES
('2000-01-01','Ivan','Ivanov','Ivanovich'),
('1977-04-20','Petr','Petrov','Petrovich'),
('1999-12-15','Ekaterina','Kant','Alekseevna'),
('2004-01-07','Anna','Malaya','Aleksandrovna'),
('1980-10-11','Roman','Nikitin','Artemovich')
GO
/*-----------------------*/

/*Заполнение таблицы library_card*/
INSERT INTO [library_card]
([person_person_id],[book_book_id])
VALUES
(1,1),
(1,3),
(2,4),
(3,5),
(5,2)
GO
/*-----------------------*/
/*Заполнение таблицы book*/
INSERT INTO [book]
([name],[author_id])
VALUES
('Cherry orchard','1'),
('War and World','2'),
('Boris Godunov','3'),
('Dead souls','4'),
('Snowstorm','3')
GO
/*-----------------------*/
/*Заполнение таблицы author*/
INSERT INTO [author]
([first_name],[last_name],[middle_name])
VALUES
('Anton','Chechov','Pavlovich'),
('Lev','Tolstoy','Nicolaevich'),
('Aleksander','Pushkin','Sergeevich'),
('Nicolay','Gogol','Vasievlevich'),
('Ivan','Turgenev','Sergeevich')
GO
/*-----------------------*/

/*Заполнение таблицы dim_genre*/
INSERT INTO [dim_genre]
([genre_name])
VALUES
('Novel'),
('Story'),
('Lyrics'),
('Drama'),
('Play'),
('Poem'),
('Tragedy')
GO
/*-----------------------*/

/*Заполнение таблицы book_genre_lnk*/
INSERT INTO [book_genre_lnk]
([book_id],[genre_id])
VALUES
(1,4),
(2,1),
(3,7),
(4,6),
(5,2)
GO
/*-----------------------*/
