USE ElLibDataBase
GO

CREATE FUNCTION SelectBooksByAuthorId(@AuthorId int) 
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT * FROM Books b
		JOIN BookAndAuthor ba 
			ON b.Id = ba.BookId
		JOIN Authors a 
			ON a.Id = ba.AuthorId
		WHERE a.Id = @AuthorId
	)