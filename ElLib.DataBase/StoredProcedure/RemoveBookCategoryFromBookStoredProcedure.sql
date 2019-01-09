USE ElLibDataBase
GO

CREATE PROC usp_RemoveBookCategoryFromBook 
	@BookId int,
	@BookCategoryId int
AS
	DELETE BookAndBookCategory
		WHERE BookId = @BookId 
		AND BookCategoryId = @BookCategoryId