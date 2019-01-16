USE ElLibDataBase
GO

CREATE PROC usp_AddBookCategoryToBook
	@BookId int,
	@BookCategoryId int
AS
	INSERT BookAndBookCategory VALUES
	(@BookId, @BookCategoryId)