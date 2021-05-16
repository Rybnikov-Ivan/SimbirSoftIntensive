USE [SimbirSoft.Intensive]
GO

/*Создание таблицы person, установка первичного ключа*/
CREATE TABLE [person] (
	[person_id] [int] IDENTITY(1,1),
	[birth_date] [date],
	[first_name] [varchar](20) NOT NULL,
	[last_name] [varchar](20) NOT NULL,
	[middle_name] [varchar](20)
)

GO

ALTER TABLE [person] 
ADD CONSTRAINT PK_person_id PRIMARY KEY CLUSTERED (person_id)
GO
/*-----------------------*/

/*Создание таблицы library_card*/
CREATE TABLE [library_card] (
	[book_book_id] [int] NOT NULL,
	[person_person_id] [int] NOT NULL
)

GO

ALTER TABLE [library_card]
  ADD CONSTRAINT FK_person_id FOREIGN KEY (person_person_id) 
  REFERENCES [person] (person_id)
GO

ALTER TABLE [library_card]
  ADD CONSTRAINT FK_book_id FOREIGN KEY (book_book_id) 
  REFERENCES [book] (book_id)
GO
/*-----------------------*/

/*Создание таблицы book*/
CREATE TABLE [book] (
	[book_id] [int] IDENTITY(1,1),
	[name] [varchar](20) NOT NULL,
	[author_id] [int] NOT NULL
)

GO
ALTER TABLE [book]
ADD CONSTRAINT PK_book_id PRIMARY KEY CLUSTERED (book_id)

ALTER TABLE [book]
ADD CONSTRAINT FK_author_id FOREIGN KEY (author_id)
REFERENCES [author] (author_id)
GO
/*-----------------------*/

/*Создание таблицы book_genre_lnk*/
CREATE TABLE [book_genre_lnk] (
	[book_id] [int] NOT NULL,
	[genre_id] [int] NOT NULL
)
GO

ALTER TABLE [book_genre_lnk]
ADD CONSTRAINT FK_book_genre_lnk_id FOREIGN KEY (book_id)
REFERENCES [book] (book_id)
GO

ALTER TABLE [book_genre_lnk]
ADD CONSTRAINT FK_genre_genre_lnk_id FOREIGN KEY (genre_id)
REFERENCES [dim_genre] (genre_id)
GO 

/*Создание таблицы dim_genre*/
CREATE TABLE [dim_genre] (
	[genre_id] [int] IDENTITY(1,1),
	[genre_name] [varchar](20) NOT NULL
)
GO

ALTER TABLE [dim_genre]
ADD CONSTRAINT PK_genre_id PRIMARY KEY CLUSTERED (genre_id)
GO

/*-----------------------*/

/*Создание таблицы author*/
CREATE TABLE [author] (
	[author_id] [int] IDENTITY(1,1),
	[first_name] [varchar](20) NOT NULL,
	[last_name] [varchar](20) NOT NULL,
	[middle_name] [varchar](20)
)
GO

ALTER TABLE [author] 
ADD CONSTRAINT PK_author_id PRIMARY KEY CLUSTERED (author_id)
GO 
/*-----------------------*/
