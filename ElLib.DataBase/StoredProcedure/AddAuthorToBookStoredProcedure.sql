USE ElLibDataBase
GO

CREATE PROC usp_AddAuthorToBook
	@AuthorId int,
	@BookId int
AS
	INSERT BookAndAuthor VALUES
	(@AuthorId, @BookId)