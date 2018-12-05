USE ElLibDataBase
GO

CREATE PROC usp_SelectBooksByAuthorId
	@AuthorId int 
AS
	SELECT * FROM Books b
	JOIN BookAndAuthor ba 
		ON b.Id = ba.BookId
	JOIN Authors a 
		ON a.Id = ba.AuthorId
	WHERE a.Id = @AuthorId