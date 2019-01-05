USE ElLibDataBase
GO

CREATE PROC usp_AddAuthorToBook
	@BookId int,
	@AuthorId int
AS
	INSERT BookAndAuthor VALUES
	(@BookId, @AuthorId)