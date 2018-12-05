USE ElLibDataBase
GO

CREATE PROC usp_AddBookCategoryToBook
	@BookCategoryId int,
	@BookId int
AS
	INSERT BookAndBookCategory VALUES
	(@BookCategoryId, @BookId)