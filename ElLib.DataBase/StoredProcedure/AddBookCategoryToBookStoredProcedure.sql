USE ElLibDataBase
GO

CREATE PROC AddBookCategoryToBook
	@BookCategoryId int,
	@BookId int
AS
	INSERT BookAndBookCategory VALUES
	(@BookCategoryId, @BookId)