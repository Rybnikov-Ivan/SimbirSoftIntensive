/*3.1*/
SELECT 
	book.name AS book, 
	concat(author.first_name, ' ', author.last_name, ' ', author.middle_name) AS author, 
	dim_genre.genre_name AS genre
FROM person
	JOIN library_card ON person.person_id = library_card.person_person_id
	JOIN book ON book.book_id = library_card.book_book_id
	JOIN author ON author.author_id = book.author_id
	JOIN book_genre_lnk ON book.book_id = book_genre_lnk.book_id
	JOIN dim_genre ON dim_genre.genre_id = book_genre_lnk.genre_id
WHERE person.person_id = 1
	
/*3.2*/
SELECT 
	concat(author.first_name, ' ', author.last_name, ' ', author.middle_name) AS author,
	book.name AS book,
	dim_genre.genre_name AS genre
FROM author
	JOIN book ON book.author_id = author.author_id
	JOIN book_genre_lnk ON book.book_id = book_genre_lnk.book_id
	JOIN dim_genre ON dim_genre.genre_id = book_genre_lnk.genre_id
WHERE author.author_id = 1

/*3.3*/
SELECT 
	dim_genre.genre_name AS genre,
	book.name AS book
FROM book
	JOIN book_genre_lnk ON book.book_id = book_genre_lnk.book_id
	JOIN dim_genre ON dim_genre.genre_id = book_genre_lnk.genre_id
WHERE dim_genre.genre_name = 'story'
		