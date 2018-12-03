USE ElLibDataBase
GO

CREATE PROC AddAuthorToBook
	@AuthorId int,
	@BookId int
AS
	INSERT BookAndAuthor VALUES
	(@AuthorId, @BookId)