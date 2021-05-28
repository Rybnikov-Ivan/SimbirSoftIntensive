USE [SimbirSoft.Intensive]
GO

/*Создание и наполнение таблицы данными*/
ALTER TABLE [book]
ADD time_of_delay int NULL
GO

UPDATE [book] SET time_of_delay = 4
WHERE book_id = 5
GO
/*******************/

/*4.1*/
SELECT 
	concat(person.first_name, ' ', person.last_name, ' ', person.middle_name) AS person,
	book.name AS book,
	book.time_of_delay
FROM person
	JOIN library_card ON person.person_id = library_card.person_person_id
	JOIN book ON book.book_id = library_card.book_book_id
WHERE book.time_of_delay > 0
/*******************/

/*4.2*/
SELECT 
	concat(person.first_name, ' ', person.last_name, ' ', person.middle_name) AS person,
	COUNT(book.name) AS books
FROM person
	JOIN library_card ON person.person_id = library_card.person_person_id
	JOIN book ON book.book_id = library_card.book_book_id
WHERE book.time_of_delay > 0
GROUP BY person.first_name, person.last_name, person.middle_name

/*4.3*/
SELECT 
	COUNT(book.name) AS books,
	SUM(book.time_of_delay) AS total_delay_time
FROM book
/*******************/