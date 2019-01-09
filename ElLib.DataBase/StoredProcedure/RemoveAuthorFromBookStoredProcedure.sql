USE ElLibDataBase
GO

CREATE PROC usp_RemoveAuthorFromBook
	@BookId int,
	@AuthorId int
AS
	DELETE BookAndAuthor
		WHERE BookId = @BookId 
		AND AuthorId = @AuthorId
